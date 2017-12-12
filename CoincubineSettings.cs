using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CoincubineWallet
{
  [Serializable]
  public class CoincubineSettings
  {
    public CoincubineSettings()
    {
      Currencies = new List<Currency>();
    }

    public List<Currency> Currencies { get; set; }

    private static string ConfigDir = string.Format("{0}{1}Long Technical{1}Coincubine{1}",
      Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
      Path.DirectorySeparatorChar);
    private static string ConfigFile = Path.Combine(ConfigDir, "CoincubineSettings.xml");

    /// <summary>
    /// Load the config file
    /// </summary>
    /// <returns></returns>
    public static CoincubineSettings Load()
    {
      try
      {
        var dir = Path.GetDirectoryName(ConfigDir);
        if (dir != null && !Directory.Exists(dir))
          Directory.CreateDirectory(dir);

        if (!File.Exists(ConfigFile))
        {
          var settings = new CoincubineSettings();
          settings.Save();
        }

        var ser = new XmlSerializer(typeof(CoincubineSettings));
        using (var sr = new StreamReader(ConfigFile))
          return (CoincubineSettings)ser.Deserialize(sr);
      }
      catch { }

      return new CoincubineSettings();
    }

    /// <summary>
    /// Save the config file
    /// </summary>
    public void Save()
    {
      try
      {
        var ser = new XmlSerializer(typeof(CoincubineSettings));
        using (var fs = new FileStream(ConfigFile, FileMode.Create))
          ser.Serialize(fs, this);
      }
      catch { }
    }
  }

  [Serializable]
  public class Currency
  {
    public Currency()
    {
      Name = "Aeon";
      Symbol = "AEON";
      Balance = "0.00000000";
      UnlockedBalance = "0.00000000";
      DaemonBinPath = ".\\aeon\\aeond.exe";
      WalletBinPath = ".\\aeon\\simplewallet.exe";
      WalletFilePath = ".\\wallets\\aeon.wallet";
      WalletKeysFilePath = ".\\wallets\\aeon.wallet.keys";
    }

    [XmlAttribute]
    public string Name { get; set; }
    [XmlAttribute]
    public string Symbol { get; set; }
    [XmlAttribute]
    public string Balance { get; set; }
    [XmlAttribute]
    public string UnlockedBalance { get; set; }
    public string DaemonBinPath { get; set; }
    public string WalletBinPath { get; set; }
    public string WalletFilePath { get; set; }
    public string WalletKeysFilePath { get; set; }
  }
}
