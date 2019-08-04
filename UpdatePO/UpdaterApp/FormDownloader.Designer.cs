namespace UpdaterApp
{
    partial class FormDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDownloader));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripMenuItem2,
            this.MnuCheckUpdate,
            this.toolStripMenuItem1,
            this.MnuClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 82);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(204, 22);
            this.mnuOpen.Text = "Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // MnuCheckUpdate
            // 
            this.MnuCheckUpdate.Name = "MnuCheckUpdate";
            this.MnuCheckUpdate.Size = new System.Drawing.Size(204, 22);
            this.MnuCheckUpdate.Text = "Проверить обновления";
            this.MnuCheckUpdate.Click += new System.EventHandler(this.MnuCheckUpdate_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // MnuClose
            // 
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(204, 22);
            this.MnuClose.Text = "Закрыть";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(0, 97);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 7);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 21;
            this.progressBar.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Обновления программного обеспечения";
            this.notifyIcon1.BalloonTipTitle = "Обновления ПО";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Обновления программного обеспечения";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Image = global::UpdaterApp.Properties.Resources.verizon_cloud;
            this.btnUpdate.Location = new System.Drawing.Point(201, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 76);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Применить обновление";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Текущий версия";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.Black;
            this.labelVersion.Location = new System.Drawing.Point(140, 43);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(40, 18);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.Text = "1.0.1";
            // 
            // FormDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 101);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновления программного обеспечения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDownloader_FormClosing);
            this.Load += new System.EventHandler(this.FormDownloader_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MnuCheckUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
    }
}