using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.Utils;

namespace Apteka.Others
{
    public partial class FrmTmp : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmTmp()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            cbDistributor.Properties.DataSource = db.Distributor.GetSp();
        }

        public tbComingProducts GetData()
        {
            var cp = new tbComingProducts();
            cp.DistributorId = cbDistributor.EditValue.ToGuid();
            cp.DocumentNo = edDocumentNo.Text;
            cp.CreateUser = Vars.UserId;

            return cp;
        }

        private void OnBtnSpListAdd(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}