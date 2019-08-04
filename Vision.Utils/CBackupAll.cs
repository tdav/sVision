using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;

namespace Apteka.Utils
{
    public class CBackupAll
    {
        private static string CurDir = AppDomain.CurrentDomain.BaseDirectory;
        public static void Run()
        {
            try
            {
                string FileName = DateTime.Now.ToString("ddMMyyyyhhmmssff");
                string ArDir = CurDir[0] + @":\ArhivBase\TexKurik\";

                if (!Directory.Exists(ArDir))
                    Directory.CreateDirectory(ArDir);


                DirectoryInfo di = new DirectoryInfo(ArDir);
                FileInfo[] fi = di.GetFiles();


                IEnumerable<FileInfo> fw = fi.Where(e => e.Name.StartsWith(FileName.Substring(0, 8)));
                if (fw?.Count() > 0)
                {
                    return;
                }

                fw = fi.OrderBy(e => e.CreationTime);

                int i = 0;
                int c = fw.Count();

                foreach (var f in fw)
                {
                    if (c - i != 2)
                    {
                        f.Delete();
                        i++;
                    }
                    else
                        break;
                }
               
                Process winExec = new Process();
                winExec.StartInfo.FileName = CurDir + "RAR.exe";
                winExec.StartInfo.Arguments = " a -r " + ArDir + FileName + ".rar " + CurDir;
                winExec.StartInfo.CreateNoWindow = false;
                winExec.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                winExec.Start();
            }
            catch (Exception ex)
            {
                Apteka.Utils.CLog.Write(ex.GetAllMessages());
            }
        }
    }
}