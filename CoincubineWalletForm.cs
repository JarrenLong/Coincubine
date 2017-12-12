using System;
using System.Windows.Forms;

namespace CoincubineWallet
{
  public partial class CoincubineWalletForm : Form
  {
    private static CoincubineWalletForm Instance = null;
    public CoincubineWalletForm()
    {
      Instance = this;
      InitializeComponent();
    }

    private void FormWallet_FormClosing(object sender, FormClosingEventArgs e)
    {
      foreach (TabPage tab in TabControlWallet.TabPages)
      {
        foreach (var ctl in tab.Controls)
        {
          if (ctl is ICloseTab)
            ((ICloseTab)ctl).CloseTab();
        }
      }
    }

    private void StatusMsg(string msg)
    {
      if (InvokeRequired)
      {
        BeginInvoke((Action)(() => { StatusMsg(msg); }));
        return;
      }

      ToolStripStatusLabel1.Text = msg;
    }

    public static void SetStatus(string msg)
    {
      Instance.StatusMsg(msg);
    }

    private void ButtonNewCurrency_Click(object sender, EventArgs e)
    {

    }

    private void ButtonManageCurrencies_Click(object sender, EventArgs e)
    {

    }

    private void AboutCoincubineToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Coincubine multi-currency wallet");
    }

    private void CoincubineWalletForm_Shown(object sender, EventArgs e)
    {
      var settings = CoincubineSettings.Load();

      foreach (var currency in settings.Currencies)
      {
        var newTabPage = new TabPage(currency.Name);

        var newTab = new UC_WalletTab();
        newTab.Dock = DockStyle.Fill;
        newTab.Currency = currency;
        newTab.StartTab();
        newTabPage.Controls.Add(newTab);

        TabControlWallet.TabPages.Add(newTabPage);
      }
    }
  }
}
