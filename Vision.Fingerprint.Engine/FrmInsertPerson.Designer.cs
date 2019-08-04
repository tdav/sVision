namespace Vision.Fingerprint.Engine
{
    partial class FrmInsertPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertPerson));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.edName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.piPhoto = new DevExpress.XtraEditors.PictureEdit();
            this.piFp3 = new DevExpress.XtraEditors.PictureEdit();
            this.piFp1 = new DevExpress.XtraEditors.PictureEdit();
            this.piFp4 = new DevExpress.XtraEditors.PictureEdit();
            this.piFp2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piPhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.edName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(730, 59);
            this.panelControl1.TabIndex = 0;
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(92, 15);
            this.edName.Name = "edName";
            // 
            // 
            // 
            this.edName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edName.Properties.Appearance.Options.UseFont = true;
            this.edName.Size = new System.Drawing.Size(582, 26);
            this.edName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(50, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ФИО";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnOk);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 430);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(730, 53);
            this.panelControl2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(608, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 37);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Бекор";
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(488, 7);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 37);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Сақлаш";
            // 
            // piPhoto
            // 
            this.piPhoto.Location = new System.Drawing.Point(7, 65);
            this.piPhoto.Name = "piPhoto";
            // 
            // 
            // 
            this.piPhoto.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piPhoto.Properties.Appearance.Options.UseBackColor = true;
            this.piPhoto.Properties.NullText = " ";
            this.piPhoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piPhoto.Size = new System.Drawing.Size(336, 353);
            this.piPhoto.TabIndex = 1;
            // 
            // piFp3
            // 
            this.piFp3.Location = new System.Drawing.Point(349, 243);
            this.piFp3.Name = "piFp3";
            // 
            // 
            // 
            this.piFp3.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piFp3.Properties.Appearance.Options.UseBackColor = true;
            this.piFp3.Properties.NullText = " ";
            this.piFp3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piFp3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piFp3.Size = new System.Drawing.Size(184, 175);
            this.piFp3.TabIndex = 1;
            // 
            // piFp1
            // 
            this.piFp1.Location = new System.Drawing.Point(349, 65);
            this.piFp1.Name = "piFp1";
            // 
            // 
            // 
            this.piFp1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piFp1.Properties.Appearance.Options.UseBackColor = true;
            this.piFp1.Properties.NullText = " ";
            this.piFp1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piFp1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piFp1.Size = new System.Drawing.Size(184, 175);
            this.piFp1.TabIndex = 1;
            // 
            // piFp4
            // 
            this.piFp4.Location = new System.Drawing.Point(539, 243);
            this.piFp4.Name = "piFp4";
            // 
            // 
            // 
            this.piFp4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piFp4.Properties.Appearance.Options.UseBackColor = true;
            this.piFp4.Properties.NullText = " ";
            this.piFp4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piFp4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piFp4.Size = new System.Drawing.Size(184, 175);
            this.piFp4.TabIndex = 1;
            // 
            // piFp2
            // 
            this.piFp2.Location = new System.Drawing.Point(539, 65);
            this.piFp2.Name = "piFp2";
            // 
            // 
            // 
            this.piFp2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.piFp2.Properties.Appearance.Options.UseBackColor = true;
            this.piFp2.Properties.NullText = " ";
            this.piFp2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piFp2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piFp2.Size = new System.Drawing.Size(184, 175);
            this.piFp2.TabIndex = 1;
            // 
            // FrmInsertPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 483);
            this.Controls.Add(this.piFp2);
            this.Controls.Add(this.piFp4);
            this.Controls.Add(this.piFp1);
            this.Controls.Add(this.piFp3);
            this.Controls.Add(this.piPhoto);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInsertPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Янги одам қўшиш";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInsertPerson_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piPhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piFp2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.PictureEdit piPhoto;
        private DevExpress.XtraEditors.PictureEdit piFp3;
        private DevExpress.XtraEditors.PictureEdit piFp1;
        private DevExpress.XtraEditors.PictureEdit piFp4;
        private DevExpress.XtraEditors.PictureEdit piFp2;
        private DevExpress.XtraEditors.TextEdit edName;
    }
}