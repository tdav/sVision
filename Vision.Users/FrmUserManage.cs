using Apteka.Models.Core;

namespace Apteka.Users
{
    public partial class FrmUserManage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IUnitOfWork db;

        public FrmUserManage()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            gridControl1.DataSource = db.User.GetAllUsers();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fu = new FrmUser();
            fu.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fu = new FrmUser();
            fu.ShowDialog();
        }
    }
}