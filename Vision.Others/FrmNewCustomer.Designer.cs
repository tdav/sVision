namespace Apteka.Others
{
    partial class FrmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewCustomer));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.edEmail = new DevExpress.XtraEditors.TextEdit();
            this.edAdress = new DevExpress.XtraEditors.TextEdit();
            this.edPhone = new DevExpress.XtraEditors.TextEdit();
            this.edFIO = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFIO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.edEmail);
            this.layoutControl1.Controls.Add(this.edAdress);
            this.layoutControl1.Controls.Add(this.edPhone);
            this.layoutControl1.Controls.Add(this.edFIO);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(381, 284);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // edEmail
            // 
            this.edEmail.EnterMoveNextControl = true;
            this.edEmail.Location = new System.Drawing.Point(14, 202);
            this.edEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edEmail.Name = "edEmail";
            this.edEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edEmail.Properties.Appearance.Options.UseFont = true;
            this.edEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.edEmail.Size = new System.Drawing.Size(353, 28);
            this.edEmail.StyleController = this.layoutControl1;
            this.edEmail.TabIndex = 11;
            // 
            // edAdress
            // 
            this.edAdress.EnterMoveNextControl = true;
            this.edAdress.Location = new System.Drawing.Point(14, 92);
            this.edAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edAdress.Name = "edAdress";
            this.edAdress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edAdress.Properties.Appearance.Options.UseFont = true;
            this.edAdress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edAdress.Size = new System.Drawing.Size(353, 28);
            this.edAdress.StyleController = this.layoutControl1;
            this.edAdress.TabIndex = 10;
            // 
            // edPhone
            // 
            this.edPhone.EnterMoveNextControl = true;
            this.edPhone.Location = new System.Drawing.Point(14, 147);
            this.edPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edPhone.Name = "edPhone";
            this.edPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPhone.Properties.Appearance.Options.UseFont = true;
            this.edPhone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edPhone.Size = new System.Drawing.Size(353, 28);
            this.edPhone.StyleController = this.layoutControl1;
            this.edPhone.TabIndex = 7;
            // 
            // edFIO
            // 
            this.edFIO.EnterMoveNextControl = true;
            this.edFIO.Location = new System.Drawing.Point(14, 37);
            this.edFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edFIO.Name = "edFIO";
            this.edFIO.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edFIO.Properties.Appearance.Options.UseFont = true;
            this.edFIO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edFIO.Size = new System.Drawing.Size(353, 28);
            this.edFIO.StyleController = this.layoutControl1;
            this.edFIO.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(381, 284);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 220);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(357, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.edFIO;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(357, 55);
            this.layoutControlItem1.Text = "Фамилии Имя Отчество";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(203, 20);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.edPhone;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(357, 55);
            this.layoutControlItem3.Text = "Телефон";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(203, 20);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.edEmail;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 165);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(357, 55);
            this.layoutControlItem7.Text = "Email";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(203, 20);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.edAdress;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(357, 55);
            this.layoutControlItem6.Text = "Адрес";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(203, 20);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 286);
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
            // FrmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 347);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmNewCustomer";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказчик";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFIO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit edFIO;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit edEmail;
        private DevExpress.XtraEditors.TextEdit edAdress;
        private DevExpress.XtraEditors.TextEdit edPhone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}