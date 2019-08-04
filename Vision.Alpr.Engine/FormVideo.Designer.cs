namespace sample
{
    partial class FormVideo
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIPCameraURL = new System.Windows.Forms.TextBox();
            this.labelParam = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numVideoFileRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseVideoFile = new System.Windows.Forms.Button();
            this.txtVideoFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.numDeviceResY = new System.Windows.Forms.NumericUpDown();
            this.numDeviceResX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDeviceIndex = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVideoFileRepeatCount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceResY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceResX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(85, 114);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(662, 542);
            this.splitContainer2.SplitterDistance = 341;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer3.Size = new System.Drawing.Size(662, 197);
            this.splitContainer3.SplitterDistance = 409;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDT,
            this.colPlate,
            this.colDirection,
            this.colPlateImage});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(409, 173);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colDT
            // 
            this.colDT.HeaderText = "Date/Time";
            this.colDT.Name = "colDT";
            this.colDT.ReadOnly = true;
            this.colDT.Width = 130;
            // 
            // colPlate
            // 
            this.colPlate.HeaderText = "Plate";
            this.colPlate.Name = "colPlate";
            this.colPlate.ReadOnly = true;
            // 
            // colDirection
            // 
            this.colDirection.HeaderText = "Dir";
            this.colDirection.Name = "colDirection";
            this.colDirection.ReadOnly = true;
            this.colDirection.Width = 30;
            // 
            // colPlateImage
            // 
            this.colPlateImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlateImage.HeaderText = "Plate Image";
            this.colPlateImage.Name = "colPlateImage";
            this.colPlateImage.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 24);
            this.panel1.TabIndex = 0;
            // 
            // btnClearResults
            // 
            this.btnClearResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearResults.Location = new System.Drawing.Point(0, 0);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(78, 24);
            this.btnClearResults.TabIndex = 0;
            this.btnClearResults.Text = "Clear";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 542);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 105);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtIPCameraURL);
            this.tabPage1.Controls.Add(this.labelParam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 79);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IP Camera";
            // 
            // txtIPCameraURL
            // 
            this.txtIPCameraURL.Location = new System.Drawing.Point(10, 29);
            this.txtIPCameraURL.Name = "txtIPCameraURL";
            this.txtIPCameraURL.Size = new System.Drawing.Size(302, 20);
            this.txtIPCameraURL.TabIndex = 16;
            // 
            // labelParam
            // 
            this.labelParam.AutoSize = true;
            this.labelParam.Location = new System.Drawing.Point(7, 13);
            this.labelParam.Name = "labelParam";
            this.labelParam.Size = new System.Drawing.Size(84, 13);
            this.labelParam.TabIndex = 15;
            this.labelParam.Text = "IP Camera URL:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.numVideoFileRepeatCount);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnBrowseVideoFile);
            this.tabPage2.Controls.Add(this.txtVideoFile);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 79);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video File";
            // 
            // numVideoFileRepeatCount
            // 
            this.numVideoFileRepeatCount.Location = new System.Drawing.Point(89, 54);
            this.numVideoFileRepeatCount.Name = "numVideoFileRepeatCount";
            this.numVideoFileRepeatCount.Size = new System.Drawing.Size(55, 20);
            this.numVideoFileRepeatCount.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Repeat count:";
            // 
            // btnBrowseVideoFile
            // 
            this.btnBrowseVideoFile.Location = new System.Drawing.Point(283, 27);
            this.btnBrowseVideoFile.Name = "btnBrowseVideoFile";
            this.btnBrowseVideoFile.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseVideoFile.TabIndex = 16;
            this.btnBrowseVideoFile.Text = "...";
            this.btnBrowseVideoFile.UseVisualStyleBackColor = true;
            this.btnBrowseVideoFile.Click += new System.EventHandler(this.btnBrowseVideoFile_Click);
            // 
            // txtVideoFile
            // 
            this.txtVideoFile.Location = new System.Drawing.Point(11, 29);
            this.txtVideoFile.Name = "txtVideoFile";
            this.txtVideoFile.Size = new System.Drawing.Size(272, 20);
            this.txtVideoFile.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Video File:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.numDeviceResY);
            this.tabPage3.Controls.Add(this.numDeviceResX);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.numDeviceIndex);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(317, 79);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video Device";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            // 
            // numDeviceResY
            // 
            this.numDeviceResY.Location = new System.Drawing.Point(167, 43);
            this.numDeviceResY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDeviceResY.Name = "numDeviceResY";
            this.numDeviceResY.Size = new System.Drawing.Size(55, 20);
            this.numDeviceResY.TabIndex = 5;
            this.numDeviceResY.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // numDeviceResX
            // 
            this.numDeviceResX.Location = new System.Drawing.Point(86, 44);
            this.numDeviceResX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDeviceResX.Name = "numDeviceResX";
            this.numDeviceResX.Size = new System.Drawing.Size(55, 20);
            this.numDeviceResX.TabIndex = 4;
            this.numDeviceResX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resolution:";
            // 
            // numDeviceIndex
            // 
            this.numDeviceIndex.Location = new System.Drawing.Point(86, 13);
            this.numDeviceIndex.Name = "numDeviceIndex";
            this.numDeviceIndex.Size = new System.Drawing.Size(55, 20);
            this.numDeviceIndex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device index:";
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormVideo";
            this.Text = "DTK LPR C# Sample  (Video)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVideoFileRepeatCount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceResY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceResX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtIPCameraURL;
        private System.Windows.Forms.Label labelParam;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numVideoFileRepeatCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseVideoFile;
        private System.Windows.Forms.TextBox txtVideoFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDeviceResY;
        private System.Windows.Forms.NumericUpDown numDeviceResX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDeviceIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirection;
        private System.Windows.Forms.DataGridViewImageColumn colPlateImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearResults;
    }
}

