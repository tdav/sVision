using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.Utils;
using System.Linq;

namespace Apteka.Others
{
    public partial class FrmDolgList : DevExpress.XtraEditors.XtraForm
    {
        private IUnitOfWork db;

        public FrmDolgList()
        {
            InitializeComponent();

            db = new UnitOfWork();
            FormClosed += (s, e) => { db.Dispose(); };

            gridControl1.DataSource = db.Customers.Find(x => x.Status == 1).ToList();
        }

        public tbCustomer GetData()
        {
            return gridView1.GetFocusedRow() as tbCustomer;
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            var f = new FrmNewCustomer();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.DataSource = db.Customers.Find(x => x.Status == 1).ToList();
                gridControl1.RefreshDataSource();
            }
            f.Dispose();
        }
    }
}