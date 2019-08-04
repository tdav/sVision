using Apteka.Models.Core;
using Apteka.Models.Entity;
using Apteka.UtilsUI.GridFunctions;

namespace Apteka.Others
{
    public partial class FrmProductList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IUnitOfWork db;
        public ReportGridForms ReportConfig { get; private set; }

        public FrmProductList()
        {
            InitializeComponent();
            gridControl.ForceInitialize();

            db = new UnitOfWork();
            FormClosed += (s, e) =>
            {
                ReportConfig?.Save(gridView1);
                db.Dispose();
            };

            ReportConfig = new ReportGridForms();
            ReportConfig.Load(gridView1, ribbonPage1.Text);
        }

        private void FrmProductList_Shown(object sender, System.EventArgs e)
        {
            gridControl.DataSource = db.Drugs.GetViDrugListForGrid();
        }

        private void btnCloseItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ShowForm(string id)
        {
            spDrug drug = null;
            if (!string.IsNullOrWhiteSpace(id))
                drug = db.Drugs.GetById(id.ToString());

            var index = gridView1.FocusedRowHandle;

            var f = new FrmNewDrug(drug);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl.DataSource = null;
                gridControl.DataSource = db.Drugs.GetViDrugListForGrid();
                gridView1.FocusedRowHandle = index;
            }
            f.Dispose();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(null);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gridView1.GetFocusedRow() as viDrugListForGrid;

            ShowForm(row.Id.ToString());
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UtilsUI.WaitFormManager.Show();
            var row = gridView1.GetFocusedRow() as viDrugListForGrid;
            db.Drugs.Remove(row.Id);
            db.Complete();
            gridControl.DataSource = db.Drugs.GetViDrugListForGrid();
            UtilsUI.WaitFormManager.Close();
        }

        private void gridControl_DoubleClick(object sender, System.EventArgs e)
        {
            btnEdit.PerformClick();
        }
    }
}