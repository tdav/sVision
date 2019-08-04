using System;
using DevExpress.XtraEditors;

namespace Apteka.Others
{
    public partial class FrmAbout : XtraForm
    {
        public FrmAbout()
        {
            InitializeComponent();
            labelControl_Version.Text = Vars.Version;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}