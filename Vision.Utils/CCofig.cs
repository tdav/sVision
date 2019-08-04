using System;
using System.Configuration;
using System.Windows.Forms;

namespace Apteka.Utils
{
    public class CCofig
    {
        //  private static string MainSection = "BIOPasport";

        private static AppSettingsSection section = new AppSettingsSection();
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        public static string GetValue(string MainSection, string sn)
        {
            string res = "";
            try
            {
                if (config.Sections[MainSection] == null)
                {
                    section.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToApplication;
                    config.Sections.Add(MainSection, section);
                }
                else section = (AppSettingsSection)config.Sections[MainSection];

                res = section.Settings[sn].Value;
            }
            catch (Exception e)
            {
                CLog.Write("CCofig->GetValue  " + e.GetAllMessages());
            }
            return res;
        }

        public static void SetValue(string MainSection, string sn, string val)
        {
            try
            {
                if (config.Sections[MainSection] == null)
                {
                    section.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToApplication;
                    config.Sections.Add(MainSection, section);
                }
                else section = (AppSettingsSection)config.Sections[MainSection];

                section.Settings.Remove(sn);
                section.Settings.Add(sn, val);
                config.Save();
            }
            catch (Exception e)
            {
                CLog.Write("CCofig->SetValue  " + e.Message);
            }
        }
    }
}