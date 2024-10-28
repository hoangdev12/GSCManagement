namespace WinFormsApp1.Views
{
    partial class Admin
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
            panel1 = new Panel();
            panel2 = new Panel();
            Viewtest = new Button();
            dataAccount = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(27, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 48);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Viewtest);
            panel2.Controls.Add(dataAccount);
            panel2.Location = new Point(31, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 355);
            panel2.TabIndex = 1;
            // 
            // Viewtest
            // 
            Viewtest.Location = new Point(231, 306);
            Viewtest.Name = "Viewtest";
            Viewtest.Size = new Size(94, 29);
            Viewtest.TabIndex = 2;
            Viewtest.Text = "button1";
            Viewtest.UseVisualStyleBackColor = true;
            Viewtest.Click += Viewtest_Click_1;
            // 
            // dataAccount
            // 
            dataAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAccount.Location = new Point(32, 25);
            dataAccount.Name = "dataAccount";
            dataAccount.RowHeadersWidth = 51;
            dataAccount.Size = new Size(687, 261);
            dataAccount.TabIndex = 1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "AdminAccount";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Viewtest;
        private DataGridView dataAccount;
    }
}