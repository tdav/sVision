namespace Apteka.Others
{
    partial class FrmNewDistributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDistributor));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbRayon = new DevExpress.XtraEditors.LookUpEdit();
            this.cbRegion = new DevExpress.XtraEditors.LookUpEdit();
            this.edDescription = new DevExpress.XtraEditors.TextEdit();
            this.edAdress = new DevExpress.XtraEditors.TextEdit();
            this.edPhone = new DevExpress.XtraEditors.TextEdit();
            this.edPersonName = new DevExpress.XtraEditors.TextEdit();
            this.edOrganizationName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbRayon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOrganizationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbRayon);
            this.layoutControl1.Controls.Add(this.cbRegion);
            this.layoutControl1.Controls.Add(this.edDescription);
            this.layoutControl1.Controls.Add(this.edAdress);
            this.layoutControl1.Controls.Add(this.edPhone);
            this.layoutControl1.Controls.Add(this.edPersonName);
            this.layoutControl1.Controls.Add(this.edOrganizationName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(381, 466);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbRayon
            // 
            this.cbRayon.EnterMoveNextControl = true;
            this.cbRayon.Location = new System.Drawing.Point(12, 255);
            this.cbRayon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRayon.Name = "cbRayon";
            this.cbRayon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRayon.Properties.Appearance.Options.UseFont = true;
            this.cbRayon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRayon.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name7")});
            this.cbRayon.Properties.DisplayMember = "Name";
            this.cbRayon.Properties.DropDownRows = 14;
            this.cbRayon.Properties.KeyMember = "Id";
            this.cbRayon.Properties.NullText = "";
            this.cbRayon.Properties.ShowFooter = false;
            this.cbRayon.Properties.ShowHeader = false;
            this.cbRayon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbRayon.Properties.ValueMember = "Id";
            this.cbRayon.Size = new System.Drawing.Size(357, 28);
            this.cbRayon.StyleController = this.layoutControl1;
            this.cbRayon.TabIndex = 7;
            // 
            // cbRegion
            // 
            this.cbRegion.EnterMoveNextControl = true;
            this.cbRegion.Location = new System.Drawing.Point(12, 200);
            this.cbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRegion.Properties.Appearance.Options.UseFont = true;
            this.cbRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRegion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name7")});
            this.cbRegion.Properties.DisplayMember = "Name";
            this.cbRegion.Properties.DropDownRows = 14;
            this.cbRegion.Properties.KeyMember = "Id";
            this.cbRegion.Properties.NullText = "";
            this.cbRegion.Properties.ShowFooter = false;
            this.cbRegion.Properties.ShowHeader = false;
            this.cbRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbRegion.Properties.ValueMember = "Id";
            this.cbRegion.Size = new System.Drawing.Size(357, 28);
            this.cbRegion.StyleController = this.layoutControl1;
            this.cbRegion.TabIndex = 7;
            // 
            // edDescription
            // 
            this.edDescription.EnterMoveNextControl = true;
            this.edDescription.Location = new System.Drawing.Point(12, 365);
            this.edDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edDescription.Name = "edDescription";
            this.edDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edDescription.Properties.Appearance.Options.UseFont = true;
            this.edDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edDescription.Size = new System.Drawing.Size(357, 28);
            this.edDescription.StyleController = this.layoutControl1;
            this.edDescription.TabIndex = 11;
            // 
            // edAdress
            // 
            this.edAdress.EnterMoveNextControl = true;
            this.edAdress.Location = new System.Drawing.Point(12, 310);
            this.edAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edAdress.Name = "edAdress";
            this.edAdress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edAdress.Properties.Appearance.Options.UseFont = true;
            this.edAdress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edAdress.Size = new System.Drawing.Size(357, 28);
            this.edAdress.StyleController = this.layoutControl1;
            this.edAdress.TabIndex = 10;
            // 
            // edPhone
            // 
            this.edPhone.EnterMoveNextControl = true;
            this.edPhone.Location = new System.Drawing.Point(12, 145);
            this.edPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edPhone.Name = "edPhone";
            this.edPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPhone.Properties.Appearance.Options.UseFont = true;
            this.edPhone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edPhone.Size = new System.Drawing.Size(357, 28);
            this.edPhone.StyleController = this.layoutControl1;
            this.edPhone.TabIndex = 7;
            // 
            // edPersonName
            // 
            this.edPersonName.EnterMoveNextControl = true;
            this.edPersonName.Location = new System.Drawing.Point(12, 90);
            this.edPersonName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edPersonName.Name = "edPersonName";
            this.edPersonName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPersonName.Properties.Appearance.Options.UseFont = true;
            this.edPersonName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edPersonName.Size = new System.Drawing.Size(357, 28);
            this.edPersonName.StyleController = this.layoutControl1;
            this.edPersonName.TabIndex = 6;
            // 
            // edOrganizationName
            // 
            this.edOrganizationName.EnterMoveNextControl = true;
            this.edOrganizationName.Location = new System.Drawing.Point(12, 35);
            this.edOrganizationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edOrganizationName.Name = "edOrganizationName";
            this.edOrganizationName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edOrganizationName.Properties.Appearance.Options.UseFont = true;
            this.edOrganizationName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edOrganizationName.Size = new System.Drawing.Size(357, 28);
            this.edOrganizationName.StyleController = this.layoutControl1;
            this.edOrganizationName.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(381, 466);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 385);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(361, 61);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.edOrganizationName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem2.Text = "Название";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(246, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.edPersonName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem1.Text = "Ответственный лицо";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(246, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.edPhone;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem3.Text = "Телефон";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(246, 20);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.edAdress;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 275);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem6.Text = "Адрес";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(246, 20);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.edDescription;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 330);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem7.Text = "Дополнительно информация";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(246, 20);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.cbRegion;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 165);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem4.Text = "Область";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(246, 20);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.cbRayon;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 220);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(361, 55);
            this.layoutControlItem5.Text = "Район";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(246, 20);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 468);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(381, 59);
            this.panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(323, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.ToolTip = "Выход";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(269, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.ToolTip = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmNewDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 529);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNewDistributor";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дистрибьюторы";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbRayon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOrganizationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.TextEdit edOrganizationName;
        private DevExpress.XtraEditors.TextEdit edPersonName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit edDescription;
        private DevExpress.XtraEditors.TextEdit edAdress;
        private DevExpress.XtraEditors.TextEdit edPhone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit cbRayon;
        private DevExpress.XtraEditors.LookUpEdit cbRegion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}