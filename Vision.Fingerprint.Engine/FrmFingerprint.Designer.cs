namespace Vision.Fingerprint.Engine
{
    partial class FrmFingerprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFingerprint));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.piFingerprint = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.piPhoto = new DevExpress.XtraEditors.PictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.timePersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piFingerprint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piPhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnNew,
            this.btnClose});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.Size = new System.Drawing.Size(1172, 143);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Новый";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.LargeImage")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Закрыть";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Отпечатков пальцев";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(111, 197);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(76, 70);
            this.popupControlContainer1.TabIndex = 2;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(3, 57);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(3, 3);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // piFingerprint
            // 
            this.piFingerprint.Dock = System.Windows.Forms.DockStyle.Top;
            this.piFingerprint.Location = new System.Drawing.Point(2, 2);
            this.piFingerprint.Name = "piFingerprint";
            this.piFingerprint.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piFingerprint.Properties.Appearance.Options.UseBackColor = true;
            this.piFingerprint.Properties.NullText = " ";
            this.piFingerprint.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piFingerprint.Size = new System.Drawing.Size(247, 393);
            this.piFingerprint.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 395);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 5);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = " ";
            // 
            // piPhoto
            // 
            this.piPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piPhoto.Location = new System.Drawing.Point(2, 400);
            this.piPhoto.Name = "piPhoto";
            this.piPhoto.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piPhoto.Properties.Appearance.Options.UseBackColor = true;
            this.piPhoto.Properties.NullText = " ";
            this.piPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piPhoto.Size = new System.Drawing.Size(247, 374);
            this.piPhoto.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.timePersonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(915, 729);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.CardCaptionFormat = " {4}";
            this.cardView1.CardWidth = 130;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPhoto,
            this.colName,
            this.colWTime});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.AllowExpandCollapse = false;
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.OptionsBehavior.Sizeable = false;
            this.cardView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            this.cardView1.OptionsView.ShowCardExpandButton = false;
            this.cardView1.OptionsView.ShowFieldCaptions = false;
            this.cardView1.OptionsView.ShowFieldHints = false;
            this.cardView1.OptionsView.ShowLines = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colWTime
            // 
            this.colWTime.FieldName = "WTime";
            this.colWTime.Name = "colWTime";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.piPhoto);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.piFingerprint);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(251, 776);
            this.panelControl1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(251, 143);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(921, 776);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(915, 729);
            this.xtraTabPage1.Text = "Бугун";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Controls.Add(this.panelControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(915, 729);
            this.xtraTabPage2.Text = "Ҳисобот";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.timePersonBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 56);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(915, 673);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colName1,
            this.colWTime1,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colName1
            // 
            this.colName1.Caption = "ФИО";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colWTime1
            // 
            this.colWTime1.Caption = "Вақти";
            this.colWTime1.FieldName = "WTime";
            this.colWTime1.Name = "colWTime1";
            this.colWTime1.Visible = true;
            this.colWTime1.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Сана";
            this.gridColumn1.FieldName = "Td";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.dateEdit2);
            this.panelControl2.Controls.Add(this.dateEdit1);
            this.panelControl2.Controls.Add(this.btnOk);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(915, 56);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(245, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Гача";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Дан";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(284, 15);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(141, 26);
            this.dateEdit2.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(69, 15);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(141, 26);
            this.dateEdit1.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.ImageOptions.Image")));
            this.btnOk.Location = new System.Drawing.Point(770, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ҳисоблаш";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmFingerprint
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 919);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFingerprint";
            this.Ribbon = this.ribbonControl;
            this.Text = "Отпечатков пальцев";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piFingerprint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piPhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraEditors.PictureEdit piFingerprint;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit piPhoto;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource timePersonBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn colWTime;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colWTime1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}
