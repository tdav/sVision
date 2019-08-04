namespace AutoUpdaterDotNET
{
    partial class RemindLaterForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.comboBoxRemindLater = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelTitle, 2);
            this.labelTitle.Location = new System.Drawing.Point(23, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Отложить загрузку новой версии?";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::AutoUpdaterDotNET.Properties.Resources.clock_go_32;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.tableLayoutPanel.SetRowSpan(this.pictureBoxIcon, 2);
            this.pictureBoxIcon.Size = new System.Drawing.Size(14, 34);
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDescription
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelDescription, 2);
            this.labelDescription.Location = new System.Drawing.Point(23, 20);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 20);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Рекомендуем загрузить обновление сейчас. Это займет всего несколько минут, в зави" +
    "симости от скорости локальной сети и Вашего компьютера.";
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Location = new System.Drawing.Point(23, 43);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(14, 14);
            this.radioButtonYes.TabIndex = 4;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Да, напомнить позднее:";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.RadioButtonYesCheckedChanged);
            // 
            // radioButtonNo
            // 
            this.tableLayoutPanel.SetColumnSpan(this.radioButtonNo, 2);
            this.radioButtonNo.Location = new System.Drawing.Point(23, 63);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(104, 14);
            this.radioButtonNo.TabIndex = 2;
            this.radioButtonNo.Text = "Нет, загрузить обновление сейчас (рекоммендуется)";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // comboBoxRemindLater
            // 
            this.comboBoxRemindLater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemindLater.FormattingEnabled = true;
            this.comboBoxRemindLater.Items.AddRange(new object[] {
            "Через 30 минут",
            "Через 12 часов",
            "Через 1 день",
            "Через 2 дня",
            "Через 4 дня",
            "Через 8 дней",
            "Через 10 дней"});
            this.comboBoxRemindLater.Location = new System.Drawing.Point(43, 43);
            this.comboBoxRemindLater.Name = "comboBoxRemindLater";
            this.comboBoxRemindLater.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRemindLater.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Image = global::AutoUpdaterDotNET.Properties.Resources.clock_play;
            this.buttonOK.Location = new System.Drawing.Point(43, 83);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 14);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.pictureBoxIcon, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.radioButtonNo, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxRemindLater, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.radioButtonYes, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelDescription, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonOK, 2, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // RemindLaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemindLaterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Напомнить об обновлении позднее";
            this.Load += new System.EventHandler(this.RemindLaterFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.ComboBox comboBoxRemindLater;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}