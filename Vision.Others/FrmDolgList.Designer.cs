namespace Apteka.Others
{
    partial class FrmDolgList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDolgList));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 346);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(839, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(6, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(47, 44);
            this.btnNew.TabIndex = 7;
            this.btnNew.ToolTip = "Сохранить";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(726, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.ToolTip = "Сохранить";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(779, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 47);
            this.btnClose.TabIndex = 6;
            this.btnClose.ToolTip = "Выход";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.EmbeddedNavigator.TextStringFormat = " {0} дан {1}";
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(839, 344);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.TabStop = false;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn1});
            this.gridView1.DetailHeight = 431;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn11.AppearanceCell.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.Caption = "ФИО";
            this.gridColumn11.FieldName = "FIO";
            this.gridColumn11.MinWidth = 50;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 238;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.Caption = "Адрес";
            this.gridColumn10.FieldName = "Address";
            this.gridColumn10.MinWidth = 23;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 301;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Телефон";
            this.gridColumn12.FieldName = "Phone";
            this.gridColumn12.MinWidth = 24;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 142;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Email";
            this.gridColumn1.FieldName = "Email";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 140;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "NAME";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "ID";
            // 
            // FrmDolgList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 407);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDolgList";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список покупателей";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}