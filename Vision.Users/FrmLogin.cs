using Apteka.Models.Core;
using Apteka.Others;
using Apteka.Utils;
using Apteka.UtilsUI;
using RawInput_dll;
using System;
using System.Windows.Forms;

namespace Apteka.Users
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private RawInput keyb;
        private IUnitOfWork db;

        public FrmLogin()
        {
            InitializeComponent();

            Vars.InitGlobalVars();
            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            lbVer.Text = "Аптека  v." + Vars.Version;
            var sl = CNet.GetGatewayAddresses();

            lbIp.Text = $"Ip адрес {CNet.LocalIpAddressAll(sl)}   шлюз {sl}";
        }

        public static DialogResult Execute()
        {
            FrmLogin frm = new FrmLogin();
            frm.edLogin.Focus();
            DialogResult res = frm.ShowDialog();
            frm.Dispose();
            return res;
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            if (Vars.InputKeybord?.Length == 0)
                Vars.InputKeybord = "Standard PS/2 Keyboard";

            var res = db.User.CheckLogin(edLogin.Text.Trim(), edPasw.Text.Trim());
            if (res.Item1?.Length == 0)
            {
                Vars.UserId = res.Item2.Id;
                Vars.UserFullName = res.Item2.ToString();

                var setup = db.Setup.FirstOrDefault();

                if (setup.IsSystemBlok && Application.ExecutablePath.Contains("Kassa"))
                {
                    MessageBoxDev.ShowMess("Система заблокировано администратором");
                    MessageBoxDev.ShowMess("Система заблокировано администратором");
                    return;
                }

                Vars.DrugStoreId = setup.DrugStoreId;
                Vars.ExtraCharge = setup.ExtraCharge;

                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                AlertMessage.Show( res.Item1);
            }
        }

        private void sbExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}