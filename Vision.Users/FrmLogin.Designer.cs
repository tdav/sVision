namespace Apteka.Users
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param TB_NAMEUZ="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.edLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.edPasw = new DevExpress.XtraEditors.TextEdit();
            this.lbVer = new DevExpress.XtraEditors.LabelControl();
            this.lbIp = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPasw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbExit
            // 
            this.sbExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbExit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sbExit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbExit.Appearance.Options.UseFont = true;
            this.sbExit.Appearance.Options.UseForeColor = true;
            this.sbExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.sbExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbExit.ImageOptions.Image")));
            this.sbExit.Location = new System.Drawing.Point(584, 258);
            this.sbExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbExit.Name = "sbExit";
            this.sbExit.Size = new System.Drawing.Size(157, 47);
            this.sbExit.TabIndex = 3;
            this.sbExit.Text = "Закрыть";
            this.sbExit.Click += new System.EventHandler(this.sbExit_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl7.Location = new System.Drawing.Point(26, 412);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(408, 22);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "тел. (+998 71) 1234567    (+998 71) 1234567";
            this.labelControl7.UseMnemonic = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(404, 102);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 23);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Пользователь";
            // 
            // sbOK
            // 
            this.sbOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sbOK.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbOK.Appearance.Options.UseFont = true;
            this.sbOK.Appearance.Options.UseForeColor = true;
            this.sbOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.sbOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbOK.ImageOptions.Image")));
            this.sbOK.Location = new System.Drawing.Point(393, 258);
            this.sbOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(157, 47);
            this.sbOK.TabIndex = 2;
            this.sbOK.Text = "Вход";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(30, 61);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(336, 315);
            this.pictureEdit1.TabIndex = 29;
            // 
            // edLogin
            // 
            this.edLogin.EditValue = "admin";
            this.edLogin.EnterMoveNextControl = true;
            this.edLogin.Location = new System.Drawing.Point(394, 132);
            this.edLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edLogin.Name = "edLogin";
            this.edLogin.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edLogin.Properties.Appearance.Options.UseFont = true;
            this.edLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.edLogin.Size = new System.Drawing.Size(348, 30);
            this.edLogin.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(406, 181);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 23);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Парол";
            // 
            // edPasw
            // 
            this.edPasw.EditValue = "1";
            this.edPasw.EnterMoveNextControl = true;
            this.edPasw.Location = new System.Drawing.Point(394, 208);
            this.edPasw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edPasw.Name = "edPasw";
            this.edPasw.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPasw.Properties.Appearance.Options.UseFont = true;
            this.edPasw.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.edPasw.Properties.PasswordChar = '@';
            this.edPasw.Size = new System.Drawing.Size(348, 30);
            this.edPasw.TabIndex = 1;
            // 
            // lbVer
            // 
            this.lbVer.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbVer.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbVer.Appearance.Options.UseFont = true;
            this.lbVer.Appearance.Options.UseForeColor = true;
            this.lbVer.Appearance.Options.UseTextOptions = true;
            this.lbVer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbVer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbVer.Location = new System.Drawing.Point(550, 15);
            this.lbVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(192, 22);
            this.lbVer.TabIndex = 30;
            this.lbVer.Text = "Аптека        v0.0.1";
            // 
            // lbIp
            // 
            this.lbIp.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIp.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbIp.Appearance.Options.UseFont = true;
            this.lbIp.Appearance.Options.UseForeColor = true;
            this.lbIp.Appearance.Options.UseTextOptions = true;
            this.lbIp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbIp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbIp.Location = new System.Drawing.Point(402, 412);
            this.lbIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(339, 22);
            this.lbIp.TabIndex = 30;
            this.lbIp.Text = "Аптека        v0.0.1";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.sbOK;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.sbExit;
            this.ClientSize = new System.Drawing.Size(763, 447);
            this.Controls.Add(this.edPasw);
            this.Controls.Add(this.edLogin);
            this.Controls.Add(this.sbExit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.lbIp);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.sbOK);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Darkroom";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация ойнаси";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPasw.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit edLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit edPasw;
        private DevExpress.XtraEditors.LabelControl lbVer;
        private DevExpress.XtraEditors.LabelControl lbIp;
    }
}