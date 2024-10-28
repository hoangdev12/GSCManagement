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
            tabAdmin = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage9 = new TabPage();
            tabAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabPage1);
            tabAdmin.Controls.Add(tabPage2);
            tabAdmin.Controls.Add(tabPage3);
            tabAdmin.Controls.Add(tabPage4);
            tabAdmin.Controls.Add(tabPage5);
            tabAdmin.Controls.Add(tabPage6);
            tabAdmin.Controls.Add(tabPage7);
            tabAdmin.Controls.Add(tabPage8);
            tabAdmin.Controls.Add(tabPage9);
            tabAdmin.Location = new Point(12, 12);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(963, 460);
            tabAdmin.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(955, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabAdmin";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(955, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Account";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(955, 427);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(955, 427);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Customer";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(955, 427);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Categories";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(955, 427);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Booking";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(955, 427);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Payment";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(955, 427);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Computer";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 29);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(955, 427);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "Employee";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 495);
            Controls.Add(tabAdmin);
            Name = "Admin";
            Text = "AdminAccount";
            tabAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdmin;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
    }
}