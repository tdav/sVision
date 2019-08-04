namespace Apteka.Reports
{
    partial class FrmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRun = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.edDate1 = new DevExpress.XtraEditors.DateEdit();
            this.edDate2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel4.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDate1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnRun,
            this.btnSave,
            this.btnClose,
            this.barButtonItem5,
            this.btnClear});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(930, 143);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnRun
            // 
            this.btnRun.Caption = "Вычислить";
            this.btnRun.Id = 2;
            this.btnRun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.ImageOptions.Image")));
            this.btnRun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRun.ImageOptions.LargeImage")));
            this.btnRun.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9);
            this.btnRun.Name = "btnRun";
            this.btnRun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRun_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Сохранить";
            this.btnSave.Id = 5;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Закрыть";
            this.btnClose.Id = 6;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.ImageOptions.ImageUri.Uri = "Home";
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnClear
            // 
            this.btnClear.Caption = "Очистить параметры ";
            this.btnClear.Id = 17;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.LargeImage")));
            this.btnClear.Name = "btnClear";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Отчет";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClear);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRun);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Дополнительно";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Выход";
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl.EmbeddedNavigator.TextStringFormat = " {0} дан {1}";
            this.gridControl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl.Location = new System.Drawing.Point(2, 20);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl.Size = new System.Drawing.Size(665, 350);
            this.gridControl.TabIndex = 13;
            this.gridControl.TabStop = false;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridView.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel4});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel4.ID = new System.Guid("f39a4acd-2b70-4afd-a7ff-b97dc698e354");
            this.dockPanel4.Location = new System.Drawing.Point(0, 143);
            this.dockPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.Options.AllowFloating = false;
            this.dockPanel4.Options.FloatOnDblClick = false;
            this.dockPanel4.Options.ShowAutoHideButton = false;
            this.dockPanel4.Options.ShowCloseButton = false;
            this.dockPanel4.Options.ShowMaximizeButton = false;
            this.dockPanel4.OriginalSize = new System.Drawing.Size(261, 119);
            this.dockPanel4.SavedSizeFactor = 0D;
            this.dockPanel4.Size = new System.Drawing.Size(261, 372);
            this.dockPanel4.Text = "Параметры отчета";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.edDate1);
            this.dockPanel4_Container.Controls.Add(this.edDate2);
            this.dockPanel4_Container.Controls.Add(this.labelControl2);
            this.dockPanel4_Container.Controls.Add(this.labelControl1);
            this.dockPanel4_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel4_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(252, 345);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // edDate1
            // 
            this.edDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edDate1.EditValue = null;
            this.edDate1.EnterMoveNextControl = true;
            this.edDate1.Location = new System.Drawing.Point(68, 7);
            this.edDate1.Name = "edDate1";
            this.edDate1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edDate1.Properties.Appearance.Options.UseFont = true;
            this.edDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDate1.Properties.EditFormat.FormatString = "";
            this.edDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edDate1.Size = new System.Drawing.Size(170, 26);
            this.edDate1.TabIndex = 19;
            // 
            // edDate2
            // 
            this.edDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edDate2.EditValue = null;
            this.edDate2.EnterMoveNextControl = true;
            this.edDate2.Location = new System.Drawing.Point(68, 39);
            this.edDate2.Name = "edDate2";
            this.edDate2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edDate2.Properties.Appearance.Options.UseFont = true;
            this.edDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edDate2.Properties.EditFormat.FormatString = "";
            this.edDate2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edDate2.Size = new System.Drawing.Size(170, 26);
            this.edDate2.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 17);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Дата по";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 17);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Дата с";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Дата прихода";
            this.gridColumn7.FieldName = "CARDTYPE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 85;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Брон";
            this.gridColumn6.FieldName = "ACTIVE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 74;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Кол.";
            this.gridColumn3.FieldName = "Qty";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 56;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(261, 143);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(669, 372);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Данные отчета";
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 515);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dockPanel4);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Name = "FrmReports";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.Text = "Отчет";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKassa_FormClosed);
            this.Load += new System.EventHandler(this.FrmKassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            this.dockPanel4_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDate1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnRun;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.BarButtonItem btnClear;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit edDate1;
        private DevExpress.XtraEditors.DateEdit edDate2;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    }
}

