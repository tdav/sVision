using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.Utils;
using Apteka.UtilsUI;
using System;

namespace Apteka.Others
{
    public partial class FrmDrugStore : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmDrugStore()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            cbRegion.Properties.DataSource = db.Region.GetSp();
            cbRegion.EditValueChanged += (s, e) =>
            {
                if (cbRegion.EditValue?.ToString() != "")
                    cbRayon.Properties.DataSource = db.District.GetSp(cbRegion.EditValue.ToStr());
            };
        }

        public spDrugStore GetData()
        {
            var d = new spDrugStore();
            d.Name = edName.Text;
            d.Phone = edPhone.Text;
            d.Fax = edFax.Text;
            d.INN = edINN.Text;
            d.MFO = edMFO.Text;
            d.OKONH = edOKONX.Text;
            d.BankName = edBankName.Text;
            d.SettlementAccount = edSettlementAccount.Text;
            d.ExtraChargeDefault = edExtraChargeDefault.Text.ToDecimal(); ;
            d.RegionId = cbRegion.EditValue.ToInt();
            d.DistrictId = cbRayon.EditValue.ToInt();
            d.Address = edAdress.Text;
            d.AddressCheck = edAddressCheck.Text;
            d.Status = 1;
            d.CreateDate = DateTime.Now;
            d.CreateUser = Vars.UserId;
            return d;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                WaitFormManager.Show();

                var sp = GetData();
                if (sp.Id == Guid.Empty)                
                    sp.Id = Guid.NewGuid();                

                db.DrugStore.Add(sp);
                db.Complete();
                AlertMessage.Show( "Данные успешно сохранены");
            }
            finally
            {
                WaitFormManager.Close();
            }
        }

        private void edAddressCheck_Enter(object sender, EventArgs e)
        {
            var s  = $"{cbRegion.Text} {cbRayon.Text} {edAdress.Text}";
            edAddressCheck.Text = s.ToLower();
        }
    }
}