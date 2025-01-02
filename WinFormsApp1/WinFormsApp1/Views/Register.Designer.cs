namespace WinFormsApp1.Views
{
    partial class Register
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtPhoneNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(337, 99);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(337, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(337, 253);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(234, 27);
            txtPhoneNum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 106);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 260);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 5;
            label3.Text = "Phone Number";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(361, 363);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtPhoneNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreate;
    }
}