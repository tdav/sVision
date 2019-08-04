using System.Threading;

namespace AutoUpdaterDotNET
{
    partial class UpdateForm
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelReleaseNotes = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(21, 143);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(805, 443);
            this.webBrowser.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Image = global::AutoUpdaterDotNET.Properties.Resources.download;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(641, 609);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(185, 38);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Установить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // labelReleaseNotes
            // 
            this.labelReleaseNotes.AutoSize = true;
            this.labelReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelReleaseNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelReleaseNotes.Location = new System.Drawing.Point(16, 105);
            this.labelReleaseNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReleaseNotes.Name = "labelReleaseNotes";
            this.labelReleaseNotes.Size = new System.Drawing.Size(211, 23);
            this.labelReleaseNotes.TabIndex = 10;
            this.labelReleaseNotes.Text = "Изменения программы:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDescription.Location = new System.Drawing.Point(16, 55);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.MaximumSize = new System.Drawing.Size(733, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(594, 20);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "{0} {1} теперь доступен. У вас установлена версия {2}. Вы хотите скачать его сейч" +
    "ас?";
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUpdate.Location = new System.Drawing.Point(16, 11);
            this.labelUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdate.MaximumSize = new System.Drawing.Size(747, 0);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(254, 25);
            this.labelUpdate.TabIndex = 8;
            this.labelUpdate.Text = "Доступна новая версия {0}!";
            // 
            // UpdateForm
            // 
            this.AcceptButton = this.buttonUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 662);
            this.Controls.Add(this.labelReleaseNotes);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} {1} доступен!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.UpdateFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelReleaseNotes;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUpdate;
    }
}