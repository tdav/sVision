using System.Configuration;

namespace Apteka.Utils
{
    public class CAppSettings
    {
        public static void Set(string name, string val)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                bool found = false;
                var ks = settings.AllKeys;
                foreach (var item in ks)
                {
                    if (item == name)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    settings.Add(name, val);
                else
                    settings[name].Value = val;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException ee)
            {
                CLog.Write(ee.Message);
                CLog.Write(ee.StackTrace);
            }
        }

        public static string Get(string name)
        {
            return ConfigurationManager.AppSettings[name].ToStr();
        }
    }
}
