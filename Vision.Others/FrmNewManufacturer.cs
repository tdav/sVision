using System;
using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.Utils;
using Apteka.UtilsUI;

namespace Apteka.Others
{
    public partial class FrmNewManufacturer : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmNewManufacturer()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            cbCountry.Properties.DataSource = db.Country.GetSp();
        }

        public spManufacturer GetData()
        {
            var cp = new spManufacturer();
            cp.Id = Guid.NewGuid();
            cp.CountryId = cbCountry.EditValue.ToInt();
            cp.Name = edName.Text;
            cp.Status = 1;
            cp.CreateDate = DateTime.Now;
            cp.CreateUser = Vars.UserId;

            return cp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var d = GetData();
            db.Manufacturer.Add(d);
            db.Complete();
        }

        private void FrmNewManufacturer_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.DialogResult== System.Windows.Forms.DialogResult.OK && cbCountry.EditValue == null)
            {
                AlertMessage.ShowError("Выберете страну");
                e.Cancel = true;
            }
        }
    }
}