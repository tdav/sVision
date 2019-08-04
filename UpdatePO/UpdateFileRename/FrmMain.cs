using Apteka.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace UpdateFileRename
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                var path = openFileDialog1.FileName;                
                var f = new FileInfo(path);                
                var fileName = $"aptekaApp@{f.Length.ToString()}@{CCRC32.GetCRC32File(path)}.zip";
                File.Move(path, f.DirectoryName+"\\"+fileName);
            }
        }
    }
}
