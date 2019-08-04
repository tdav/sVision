namespace Apteka.Others
{
    partial class FrmSpList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridInpektors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbDiagnostika = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInpektors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiagnostika)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridInpektors;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbDiagnostika});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(626, 771);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridInpektors});
            // 
            // gridInpektors
            // 
            this.gridInpektors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn2});
            this.gridInpektors.DetailHeight = 431;
            this.gridInpektors.GridControl = this.gridControl1;
            this.gridInpektors.Name = "gridInpektors";
            this.gridInpektors.NewItemRowText = "Янги маълумот қўшиш учун бу жойга босинг ";
            this.gridInpektors.OptionsCustomization.AllowGroup = false;
            this.gridInpektors.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridInpektors.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridInpektors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridInpektors.OptionsView.ShowAutoFilterRow = true;
            this.gridInpektors.OptionsView.ShowGroupPanel = false;
            this.gridInpektors.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridInpektors_InitNewRow);
            this.gridInpektors.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridSp_ValidateRow);
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "№";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.MaxWidth = 47;
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 47;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "Название";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // cbDiagnostika
            // 
            this.cbDiagnostika.AutoHeight = false;
            this.cbDiagnostika.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDiagnostika.DisplayMember = "Name";
            this.cbDiagnostika.Name = "cbDiagnostika";
            this.cbDiagnostika.NullText = "";
            this.cbDiagnostika.ShowHeader = false;
            this.cbDiagnostika.ValueMember = "TB_ID";
            // 
            // FrmSpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 775);
            this.Controls.Add(this.gridControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSpList";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочный таблица";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSpList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInpektors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiagnostika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridInpektors;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbDiagnostika;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}