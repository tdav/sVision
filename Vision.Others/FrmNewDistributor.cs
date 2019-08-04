using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.Utils;
using System;

namespace Apteka.Others
{
    public partial class FrmNewDistributor : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmNewDistributor()
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

        public spDistributor GetData()
        {
            var d = new spDistributor();
            d.PersonName = edPersonName.Text;
            d.OrganizationName = edOrganizationName.Text;
            d.CreateDate = DateTime.Now;
            d.CreateUser = Vars.UserId;
            d.Description = edDescription.Text;
            d.RegionId = cbRegion.EditValue.ToInt();
            d.DistrictId = cbRayon.EditValue.ToInt();
            d.Phone = edPhone.Text;
            d.Status = 1;
            return d;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            spDistributor sp = GetData();
            if (sp.Id == Guid.Empty)
            {
                sp.Id = Guid.NewGuid();
            }

            db.Distributor.Add(sp);
            db.Complete();
            UtilsUI.AlertMessage.Show("Данные успешно сохранены");
        }
    }
}