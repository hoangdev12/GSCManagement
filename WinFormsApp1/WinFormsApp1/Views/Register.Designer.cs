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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtPhoneNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(407, 74);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(407, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(407, 205);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(234, 27);
            txtPhoneNum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(259, 78);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(271, 144);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(297, 209);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(421, 341);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(407, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Image = (Image)resources.GetObject("lblEmail.Image");
            lblEmail.Location = new Point(302, 271);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "Register";
            Text = "Register";
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
        private TextBox txtEmail;
        private Label lblEmail;
    }
}