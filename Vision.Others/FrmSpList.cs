using System.Windows.Forms;


namespace Apteka.Others
{
    public partial class FrmSpList : DevExpress.XtraEditors.XtraForm
    {
//        Asbt.ClientData.Db dmodule;

        public FrmSpList()
        {
            InitializeComponent();
        }

        //public frmInpektors(Asbt.ClientData.Db db)
        //{
        //    InitializeComponent();

            //dmodule = db;
            //sp_InspektorBindingSource.DataSource = dmodule.LoadSpr("sp_Inspektors");
            //cbDiagnostika.Properties.DataSource = dmodule.LoadSpr("sp_Diagnostika");
        //}

        private void frmSpList_FormClosed(object sender, FormClosedEventArgs e)
        {
            //dmodule = null;
        }
        
        private void gridSp_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
        //    if (string.IsNullOrEmpty(e.ErrorText))
        //    {
        //        sp_Inspektor tm = e.Row as sp_Inspektor;
                
        //        if (tm == null) return;

        //        if (IsNewRow)
        //            dmodule.AddSpInspektor(tm);
        //        else
        //            dmodule.Save();
        //        IsNewRow = false;
        //    }
        }
        
        private void gridInpektors_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //IsNewRow = true;

            //sp_Inspektor tm = sp_InspektorBindingSource.Current as sp_Inspektor;
            //if (tm == null) return;

            //tm.dateBegin = DateTime.Now;
            //tm.active = 1;
        }
      
    }
}