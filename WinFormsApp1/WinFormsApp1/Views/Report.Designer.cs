namespace WinFormsApp1.Views
{
    partial class Report
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
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            SaveChartDataToExcel = new Button();
            SuspendLayout();
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Dock = DockStyle.Right;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(910, 0);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(151, 28);
            comboBoxMonth.TabIndex = 0;
            comboBoxMonth.Text = "Tháng";
            // 
            // comboBoxYear
            // 
            comboBoxYear.Dock = DockStyle.Right;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(759, 0);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.RightToLeft = RightToLeft.No;
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 1;
            comboBoxYear.Text = "Năm";
            // 
            // SaveChartDataToExcel
            // 
            SaveChartDataToExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveChartDataToExcel.Location = new Point(933, 469);
            SaveChartDataToExcel.Name = "SaveChartDataToExcel";
            SaveChartDataToExcel.Size = new Size(94, 29);
            SaveChartDataToExcel.TabIndex = 2;
            SaveChartDataToExcel.Text = "Export";
            SaveChartDataToExcel.UseVisualStyleBackColor = true;
            SaveChartDataToExcel.Click += SaveChartDataToExcel_Click_1;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 510);
            Controls.Add(SaveChartDataToExcel);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Name = "Report";
            Text = "Report";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private Button SaveChartDataToExcel;
    }
}