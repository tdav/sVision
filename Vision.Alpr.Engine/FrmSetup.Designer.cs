namespace Vision.Alpr.Engine
{
    partial class FrmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBurnPos = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBurnString = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbRecognitionOnMotion = new System.Windows.Forms.CheckBox();
            this.numNumThreads = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numFPSLimit = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountryCodes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numMaxCharHeight = new System.Windows.Forms.NumericUpDown();
            this.numMinCharHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFPSLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbBurnPos);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtBurnString);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbRecognitionOnMotion);
            this.groupBox1.Controls.Add(this.numNumThreads);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numFPSLimit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCountryCodes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numMaxCharHeight);
            this.groupBox1.Controls.Add(this.numMinCharHeight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 317);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LPR Settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(103, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Example: FR,DE,ES,IT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(250, 21);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "%DATETIME% | %PLATE_NUM% (%COUNTRY%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Example:";
            // 
            // cmbBurnPos
            // 
            this.cmbBurnPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBurnPos.FormattingEnabled = true;
            this.cmbBurnPos.Items.AddRange(new object[] {
            "LEFT_TOP",
            "RIGHT_TOP",
            "LEFT_BOTTOM",
            "RIGHT_BOTTOM"});
            this.cmbBurnPos.Location = new System.Drawing.Point(65, 266);
            this.cmbBurnPos.Name = "cmbBurnPos";
            this.cmbBurnPos.Size = new System.Drawing.Size(121, 21);
            this.cmbBurnPos.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Location:";
            // 
            // txtBurnString
            // 
            this.txtBurnString.Location = new System.Drawing.Point(10, 219);
            this.txtBurnString.Name = "txtBurnString";
            this.txtBurnString.Size = new System.Drawing.Size(304, 21);
            this.txtBurnString.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Burn the following string on result image:";
            // 
            // cbRecognitionOnMotion
            // 
            this.cbRecognitionOnMotion.AutoSize = true;
            this.cbRecognitionOnMotion.Location = new System.Drawing.Point(11, 122);
            this.cbRecognitionOnMotion.Name = "cbRecognitionOnMotion";
            this.cbRecognitionOnMotion.Size = new System.Drawing.Size(132, 17);
            this.cbRecognitionOnMotion.TabIndex = 10;
            this.cbRecognitionOnMotion.Text = "Recognition on motion";
            this.cbRecognitionOnMotion.UseVisualStyleBackColor = true;
            // 
            // numNumThreads
            // 
            this.numNumThreads.Location = new System.Drawing.Point(175, 175);
            this.numNumThreads.Name = "numNumThreads";
            this.numNumThreads.Size = new System.Drawing.Size(64, 21);
            this.numNumThreads.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Number of threads:";
            // 
            // numFPSLimit
            // 
            this.numFPSLimit.Location = new System.Drawing.Point(175, 149);
            this.numFPSLimit.Name = "numFPSLimit";
            this.numFPSLimit.Size = new System.Drawing.Size(64, 21);
            this.numFPSLimit.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Processing FPS limit (0 - no limit):";
            // 
            // txtCountryCodes
            // 
            this.txtCountryCodes.Location = new System.Drawing.Point(92, 75);
            this.txtCountryCodes.Name = "txtCountryCodes";
            this.txtCountryCodes.Size = new System.Drawing.Size(126, 21);
            this.txtCountryCodes.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Country codes:";
            // 
            // numMaxCharHeight
            // 
            this.numMaxCharHeight.Location = new System.Drawing.Point(154, 49);
            this.numMaxCharHeight.Name = "numMaxCharHeight";
            this.numMaxCharHeight.Size = new System.Drawing.Size(64, 21);
            this.numMaxCharHeight.TabIndex = 3;
            // 
            // numMinCharHeight
            // 
            this.numMinCharHeight.Location = new System.Drawing.Point(154, 26);
            this.numMinCharHeight.Name = "numMinCharHeight";
            this.numMinCharHeight.Size = new System.Drawing.Size(64, 21);
            this.numMinCharHeight.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Maximum character height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Minimum character height:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(3, 320);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(328, 55);
            this.panelControl1.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.ImageUri.Uri = "Close;Colored";
            this.btnCancel.Location = new System.Drawing.Point(175, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 42);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отменить";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageUri.Uri = "Close;Colored";
            this.btnSave.Location = new System.Drawing.Point(30, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSetup";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Настройка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFPSLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbBurnPos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBurnString;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbRecognitionOnMotion;
        private System.Windows.Forms.NumericUpDown numNumThreads;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numFPSLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountryCodes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMaxCharHeight;
        private System.Windows.Forms.NumericUpDown numMinCharHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}