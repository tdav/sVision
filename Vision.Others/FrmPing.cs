using Apteka.Utils;
using System;
using System.Windows.Forms;


namespace Apteka.Others
{
    public partial class FrmPing : DevExpress.XtraEditors.XtraForm
    {
        public FrmPing()
        {
            InitializeComponent();
            meLog.Text = "Таромоқ текширилмоқда";
        }

        private void frmPing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void meLog_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
        private void meLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPing_Shown(object sender, EventArgs e)
        {
            meLog.Text = "";
            string ip = CNet.GetGatewayAddresses();
            if (!CNet.LocalIpAddress().Contains("10.10"))
            {
                if (ip == "")
                    meLog.Text += "Хато - Шлюз";
                else
                    meLog.Text += CNet.Ping("Шлюз ", ip);

                meLog.Text += Environment.NewLine;
            }
            
            meLog.Text += CNet.Ping("Сервер ", "172.250.1.206");
        }


    }
}