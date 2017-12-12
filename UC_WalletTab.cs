using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoincubineWallet
{
  public partial class UC_WalletTab : UserControl, ICloseTab
  {
    public Currency Currency { get; set; }
    private Process DaemonProcess { get; set; }
    private Process WalletProcess { get; set; }
    private System.Threading.Timer DaemonRefreshTimer { get; set; }

    public UC_WalletTab()
    {
      InitializeComponent();
    }

    public void StartTab()
    {
      if (Currency == null)
      {
        CoincubineWalletForm.SetStatus("No currency configured for this tab!");
        return;
      }

      try
      {
        StartDaemon();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Could not start " + Currency.DaemonBinPath + ": " + ex.Message,
          Currency.Name + " Wallet", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //Environment.Exit(1);
      }

      if (string.IsNullOrEmpty(Currency.WalletFilePath))
        Currency.WalletFilePath = Path.Combine(Application.UserAppDataPath, Currency.Name + ".wallet");
      if (string.IsNullOrEmpty(Currency.WalletKeysFilePath))
        Currency.WalletKeysFilePath = Path.Combine(Application.UserAppDataPath, Currency.Name + ".wallet.keys");

      if (!File.Exists(Currency.WalletKeysFilePath))
      {
        CoincubineWalletForm.SetStatus("Enter your password, then press Create Wallet");

        ButtonOpenWallet.Text = "Create Wallet";
      }
      else
      {
        ButtonOpenWallet.Text = "Open Wallet";
      }

      ActiveControl = TextBoxPassword;

      DaemonRefreshTimer = new System.Threading.Timer((o) => { RefreshDaemon(); }, null, 5000, 5000);
    }

    private void RefreshDaemon()
    {
      try
      {
        DaemonProcess.StandardInput.Write("set_log 0\r\n");
        DaemonProcess.StandardInput.Flush();
      }
      catch { }
    }

    private void StartDaemon()
    {
      DaemonProcess = new Process()
      {
        StartInfo = new ProcessStartInfo(Currency.DaemonBinPath)
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          WindowStyle = ProcessWindowStyle.Hidden,
          RedirectStandardOutput = true,
          RedirectStandardError = true,
          RedirectStandardInput = true
        }
      };
      DaemonProcess.EnableRaisingEvents = true;
      DaemonProcess.ErrorDataReceived += DaemonProcess_ErrorDataReceived;
      DaemonProcess.OutputDataReceived += DaemonProcess_OutputDataReceived;
      DaemonProcess.Exited += DaemonProcess_Exited;
      DaemonProcess.Start();
      DaemonProcess.BeginOutputReadLine();
      DaemonProcess.BeginErrorReadLine();
    }

    private void StartWallet(string arguments)
    {
      WalletProcess = new Process()
      {
        StartInfo = new ProcessStartInfo(Currency.WalletBinPath, arguments)
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          WindowStyle = ProcessWindowStyle.Hidden,
          RedirectStandardOutput = true,
          RedirectStandardError = true,
          RedirectStandardInput = true
        }
      };
      WalletProcess.EnableRaisingEvents = true;
      WalletProcess.OutputDataReceived += WalletProcess_OutputDataReceived;
      WalletProcess.Exited += WalletProcess_Exited;
      WalletProcess.Start();
      WalletProcess.BeginOutputReadLine();
      WalletProcess.BeginErrorReadLine();
    }

    public void CloseTab()
    {
      if (Currency == null)
        return;

      try { DaemonProcess.Kill(); }
      catch { }

      if (WalletProcess != null)
      {
        try { WalletProcess.Kill(); }
        catch { }
      }

      if (WalletProcess != null)
      {
        WalletProcess.StandardInput.Write("exit\r\n");
        WalletProcess.StandardInput.Flush();
      }

      DaemonProcess.StandardInput.Write("exit\r\n");
      DaemonProcess.StandardInput.Flush();

      if (!DaemonProcess.WaitForExit(1) || (WalletProcess != null && !WalletProcess.WaitForExit(1)))
      {
        // MessageBox.Show("Waiting for Daemon to finish before exiting");
        BeginInvoke((Action)(() => { TextBoxDaemon.AppendText("\r\n*** Waiting for Daemon and Wallet to finish ***\r\n\r\n"); }));
      }
    }

    void DaemonProcess_Exited(object sender, EventArgs e)
    {
      BeginInvoke((Action)(() =>
      {
        if (WalletProcess == null || (WalletProcess != null && WalletProcess.WaitForExit(1)))
        {
          if (DaemonProcess.ExitCode != 0)
            MessageBox.Show("An error caused the Daemon to exit (with code " + DaemonProcess.ExitCode + @").",
              Currency.Name + " Wallet - Daemon Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

          //Environment.Exit(0);
        }
      }));
    }

    private void WalletProcess_Exited(object sender, EventArgs e)
    {
      BeginInvoke((Action)(() =>
      {
        DaemonProcess.WaitForExit(1);
        //if (DaemonProcess.WaitForExit(1))
        //Environment.Exit(0);
      }));
    }

    private void WalletProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
    {
      if (!string.IsNullOrEmpty(e.Data))
      {
        if (e.Data.StartsWith("Opened wallet:"))
        {
          BeginInvoke((Action)(() =>
          {
            TextBoxAddress.Text = e.Data.Substring(15);
            TextBoxAddress.Visible = true;
            ButtonOpenWallet.Text = "Refresh";
            GroupBoxTransfer.Enabled = true;
            ButtonExportKeys.Enabled = true;
            ButtonImportKeys.Enabled = true;
          }));
        }
        else if (e.Data.StartsWith("balance:"))
        {
          BeginInvoke((Action)(() =>
          {
            CoincubineWalletForm.SetStatus("");

            string balance = e.Data.Substring(9);

            Currency.Balance = balance.Substring(0, balance.IndexOf(","));

            balance = balance.Substring(balance.IndexOf("unlocked balance:") + 18);
            Currency.UnlockedBalance = balance;

            LabelBalance.Text = Currency.Balance + " " + Currency.Symbol;
            LabelUnlockedBalance.Text = Currency.UnlockedBalance + " " + Currency.Symbol;
          }));
        }
        else if (e.Data.StartsWith("Error:"))
        {
          BeginInvoke((Action)(() =>
          {
            CoincubineWalletForm.SetStatus("");
            MessageBox.Show(e.Data.Substring(7), Currency.Name + " Wallet Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }));
        }
        else if (e.Data.StartsWith("[wallet ") && e.Data.IndexOf("]: Error:") != -1)
        {
          BeginInvoke((Action)(() =>
          {
            CoincubineWalletForm.SetStatus("");
            MessageBox.Show(e.Data.Substring(e.Data.IndexOf("]: Error:") + 3), Currency.Name + " Wallet Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }));
        }
        else if (e.Data.StartsWith("Height ") && e.Data.IndexOf(" of ") != -1)
        {
          CoincubineWalletForm.SetStatus(e.Data);
        }
        else if (e.Data.StartsWith("Starting refresh"))
        {
          BeginInvoke((Action)(() =>
          {
            CoincubineWalletForm.SetStatus("");

            ButtonOpenWallet.Enabled = false;
            ButtonExportKeys.Enabled = false;
            ButtonImportKeys.Enabled = false;
          }));
        }
        else if (e.Data.StartsWith("Refresh done"))
        {
          WalletProcess.StandardInput.Write("incoming_transfers\r\n");
          WalletProcess.StandardInput.Flush();

          BeginInvoke((Action)(() =>
          {
            CoincubineWalletForm.SetStatus("");

            ButtonOpenWallet.Enabled = true;
            ButtonExportKeys.Enabled = true;
            ButtonImportKeys.Enabled = true;
          }));
        }
        else if (e.Data.StartsWith("         amount       \t"))
        {
          DataGridViewTransactions.Rows.Clear();
        }
        else if (e.Data.IndexOf("\t  F  \t") != -1 || e.Data.IndexOf("\t  T  \t") != -1)
        {
          string[] parts = Regex.Replace(e.Data, "\\s+", " ").Split(' ');

          if (parts.Length == 5)
          {
            BeginInvoke((Action)(() =>
            {
              DataGridViewTransactions.Rows.Add(parts[1], parts[2] == "F" ? "received" : "spent", parts[4]);
            }));
          }
        }
        else if (e.Data.StartsWith("Money successfully sent") || (e.Data.StartsWith("[wallet ") && e.Data.IndexOf("]: Money successfully sent") != -1))
        {
          BeginInvoke((Action)(() =>
          {
            if (e.Data.IndexOf("]: Money successfully sent") != -1)
              MessageBox.Show(e.Data.Substring(e.Data.IndexOf("]: Money") + 3), Currency.Name + " Wallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
              MessageBox.Show(e.Data, Currency.Name + " Wallet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TextBoxAmount.Text = "";

            WalletProcess.StandardInput.Write("refresh\r\n");
            WalletProcess.StandardInput.Flush();
          }));
        }
        else
        {
          Console.WriteLine("wallet unhandled: " + e.Data + "\r\n");
        }
      }
    }

    void DaemonProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
    {
      if (!string.IsNullOrEmpty(e.Data))
        BeginInvoke((Action)(() => { TextBoxDaemon.AppendText(e.Data + "\r\n"); }));
    }

    void DaemonProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
    {
      if (!string.IsNullOrEmpty(e.Data))
        BeginInvoke((Action)(() => { TextBoxDaemon.AppendText("[err] " + e.Data + "\r\n"); }));
    }

    private void ButtonOpenWallet_Click(object sender, EventArgs e)
    {
      if (ButtonOpenWallet.Text == "Create Wallet")
      {
        if (TextBoxPassword.Text.Length == 0)
        {
          MessageBox.Show("Please enter (and remember) the password first.", Currency.Name + " Wallet", MessageBoxButtons.OK, MessageBoxIcon.Error);

          return;
        }

        try
        {
          StartWallet("--generate-new-wallet \"" + Currency.WalletFilePath + "\" --password \"" + TextBoxPassword.Text + "\" --command \"exit\"");
        }
        catch (Exception ex)
        {
          MessageBox.Show("Could not start " + Currency.WalletBinPath + ": " + ex.Message, Currency.Name + " Wallet", MessageBoxButtons.OK, MessageBoxIcon.Error);

          //Environment.Exit(1);
        }

        ButtonOpenWallet.Text = "Open Wallet";

        //labelInfo.Text = "Enter your password, then press Open Wallet";
      }
      else if (ButtonOpenWallet.Text == "Open Wallet")
      {
        try
        {
          StartWallet("--wallet \"" + Currency.WalletFilePath + "\" --password \"" + TextBoxPassword.Text + "\"");
        }
        catch (Exception ex)
        {
          MessageBox.Show("Could not start " + Currency.WalletBinPath + ": " + ex.Message, Currency.Name + " Wallet", MessageBoxButtons.OK, MessageBoxIcon.Error);

          //Environment.Exit(1);
        }
      }
      else // Refresh
      {
        ButtonOpenWallet.Enabled = false;

        WalletProcess.StandardInput.Write("refresh\r\n");
        WalletProcess.StandardInput.Flush();
      }
    }

    private void ButtonImportKeys_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog()
      {
        Title = Currency.Name + " Wallet - import keys",
        Filter = "Wallet keys (*.keys)|*.keys"
      };

      if (ofd.ShowDialog() == DialogResult.OK)
      {
        if (File.Exists(Currency.WalletKeysFilePath))
        {
          if (MessageBox.Show("A wallet already exists. Importing the new keys would erase the old wallet. Please only do this if you exported and save the keys before. Do you want to continue importing the keys?",
            Currency.Name + " Wallet - Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            File.Move(Currency.WalletKeysFilePath, Currency.WalletKeysFilePath + "." + Guid.NewGuid().ToString());
          else
            return;
        }

        File.Copy(ofd.FileName, Currency.WalletKeysFilePath);

        File.Delete(Path.Combine(Application.UserAppDataPath, "wallet"));
        File.Delete(Path.Combine(Application.UserAppDataPath, "wallet.address.txt"));

        TextBoxPassword.Text = "";
        TextBoxAddress.Text = "";
        LabelBalance.Text = "0.000000000000 " + Currency.Symbol;
        LabelUnlockedBalance.Text = "0.000000000000 " + Currency.Symbol;

        TextBoxAddress.Visible = false;

        ButtonOpenWallet.Text = "Open Wallet";
        CoincubineWalletForm.SetStatus("Enter your password, then press Open Wallet");

        GroupBoxTransfer.Enabled = false;

        if (WalletProcess != null)
          WalletProcess.Kill();
      }
    }

    private void ButtonExportKeys_Click(object sender, EventArgs e)
    {
      var sfd = new SaveFileDialog()
      {
        Title = Currency.Name + " Wallet - export keys",
        Filter = "Wallet keys (*.wallet.keys)|*.wallet.keys",
        FileName = Currency.Name + ".wallet.keys"
      };

      if (sfd.ShowDialog() == DialogResult.OK)
        File.Copy(Currency.WalletKeysFilePath, sfd.FileName);
    }

    private void TextBoxAmount_TextChanged(object sender, EventArgs e)
    {
      double value = 0;
      double.TryParse(TextBoxAmount.Text, out value);

      if (value > 0)
      {
        LabelTotalAmount.Text = (value + 0.005).ToString("0.000000000000") + " " + Currency.Symbol;

        ButtonSend.Enabled = true;
      }
      else
      {
        LabelTotalAmount.Text = (0.0).ToString("0.000000000000") + " " + Currency.Symbol;

        ButtonSend.Enabled = false;
      }
    }

    private void ButtonSend_Click(object sender, EventArgs e)
    {
      var cmd = string.Format("transfer {0} {1} {2}{3}\r\n",
        TextBoxMixinCount.Text,
        TextBoxDestinationAddress.Text,
        TextBoxAmount.Text,
        TextBoxPaymentId.Text.Length > 0 ? (" " + TextBoxPaymentId.Text) : ""
        );

      WalletProcess.StandardInput.Write(cmd);
      WalletProcess.StandardInput.Flush();
    }

    private void ButtonDonate_Click(object sender, EventArgs e)
    {
      TextBoxAmount.Text = "10";
      TextBoxDestinationAddress.Text = "1QjQzA9T8cm4dttSKb27cv3EL9hwvzQqKXytiJEwUCJ44fXPSBRbXsMSpEFbFkUcT7feY9yrDnNYFgsU2JYii6f22W61naV";
      TextBoxMixinCount.Text = "0";
      TextBoxPaymentId.Text = "";

      MessageBox.Show("Your donation will help further development of the wallet.",
        "Please press Send to make the donation.", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
