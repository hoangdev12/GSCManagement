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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            dgvBooking = new DataGridView();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            panel1 = new Panel();
            panel4 = new Panel();
            txtTongTien = new TextBox();
            lblTongTien = new Label();
            panel3 = new Panel();
            txtConLai = new TextBox();
            lblConLai = new Label();
            panel2 = new Panel();
            txtDaChoi = new TextBox();
            lblDaChoi = new Label();
            flpComputers = new FlowLayoutPanel();
            tabPage8 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            tabPage7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(967, 483);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(959, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(959, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(959, 450);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Customer";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(959, 450);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Categories";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvBooking);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(959, 450);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Booking";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvBooking
            // 
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(10, 13);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.RowHeadersWidth = 51;
            dgvBooking.Size = new Size(946, 432);
            dgvBooking.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(959, 450);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Payment";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(panel1);
            tabPage7.Controls.Add(flpComputers);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(959, 450);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Computer";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(627, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 432);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTongTien);
            panel4.Controls.Add(lblTongTien);
            panel4.Location = new Point(3, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(308, 59);
            panel4.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(114, 19);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(174, 27);
            txtTongTien.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(13, 18);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(95, 28);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtConLai);
            panel3.Controls.Add(lblConLai);
            panel3.Location = new Point(3, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 59);
            panel3.TabIndex = 2;
            // 
            // txtConLai
            // 
            txtConLai.Location = new Point(114, 19);
            txtConLai.Name = "txtConLai";
            txtConLai.ReadOnly = true;
            txtConLai.Size = new Size(174, 27);
            txtConLai.TabIndex = 1;
            // 
            // lblConLai
            // 
            lblConLai.AutoSize = true;
            lblConLai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConLai.Location = new Point(18, 16);
            lblConLai.Name = "lblConLai";
            lblConLai.Size = new Size(72, 28);
            lblConLai.TabIndex = 0;
            lblConLai.Text = "Còn lại";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDaChoi);
            panel2.Controls.Add(lblDaChoi);
            panel2.Location = new Point(3, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 59);
            panel2.TabIndex = 0;
            // 
            // txtDaChoi
            // 
            txtDaChoi.Location = new Point(114, 19);
            txtDaChoi.Name = "txtDaChoi";
            txtDaChoi.ReadOnly = true;
            txtDaChoi.Size = new Size(174, 27);
            txtDaChoi.TabIndex = 1;
            // 
            // lblDaChoi
            // 
            lblDaChoi.AutoSize = true;
            lblDaChoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDaChoi.Location = new Point(18, 16);
            lblDaChoi.Name = "lblDaChoi";
            lblDaChoi.Size = new Size(83, 28);
            lblDaChoi.TabIndex = 0;
            lblDaChoi.Text = "Đã chơi ";
            // 
            // flpComputers
            // 
            flpComputers.Location = new Point(6, 8);
            flpComputers.Name = "flpComputers";
            flpComputers.Size = new Size(615, 437);
            flpComputers.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(959, 450);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Employee";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 498);
            Controls.Add(tabControl1);
            Name = "Admin";
            Text = "Admin";
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            tabPage7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView dgvBooking;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Panel panel1;
        private FlowLayoutPanel flpComputers;
        private Panel panel2;
        private Label lblDaChoi;
        private Panel panel4;
        private TextBox txtTongTien;
        private Label lblTongTien;
        private Panel panel3;
        private TextBox txtConLai;
        private Label lblConLai;
        private TextBox txtDaChoi;
    }
}