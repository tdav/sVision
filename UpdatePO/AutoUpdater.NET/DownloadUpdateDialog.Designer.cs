namespace AutoUpdaterDotNET
{
    partial class DownloadUpdateDialog
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
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::AutoUpdaterDotNET.Properties.Resources.download_32;
            this.pictureBoxIcon.Location = new System.Drawing.Point(11, 26);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(54, 43);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(80, 41);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(371, 28);
            this.progressBar.TabIndex = 2;
            // 
            // labelInformation
            // 
            this.labelInformation.Location = new System.Drawing.Point(80, 15);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(371, 21);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Загружается обновление...";
            // 
            // DownloadUpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 92);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadUpdateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Обновление программы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadUpdateDialog_FormClosing);
            this.Load += new System.EventHandler(this.DownloadUpdateDialogLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelInformation;
    }
}