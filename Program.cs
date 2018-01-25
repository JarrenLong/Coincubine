using LongTech.Portable;
using System;
using System.Windows.Forms;

namespace CoincubineWallet
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      PortableLib.Initialize();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new CoincubineWalletForm());
    }
  }
}
