namespace WinFormsApp1.Views
{
    partial class User
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnBuy = new Guna.UI2.WinForms.Guna2Button();
            btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            pnlStatus = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTotalAll = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvCart = new DataGridView();
            tbpService = new TabPage();
            tbpDrinks = new TabPage();
            tbpFoods = new TabPage();
            tbcUser = new Guna.UI2.WinForms.Guna2TabControl();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            tbcUser.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.CustomizableEdges = customizableEdges1;
            btnBuy.DisabledState.BorderColor = Color.DarkGray;
            btnBuy.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuy.FillColor = Color.FromArgb(33, 42, 57);
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(69, 613);
            btnBuy.Name = "btnBuy";
            btnBuy.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBuy.Size = new Size(225, 56);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Buy";
            btnBuy.Click += btnBuy_Click_1;
            // 
            // btnLogOut
            // 
            btnLogOut.CustomizableEdges = customizableEdges3;
            btnLogOut.DisabledState.BorderColor = Color.DarkGray;
            btnLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogOut.FillColor = Color.FromArgb(33, 42, 57);
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(69, 675);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogOut.Size = new Size(225, 56);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.FromArgb(33, 42, 57);
            pnlStatus.Controls.Add(guna2HtmlLabel1);
            pnlStatus.Controls.Add(lblTotalAll);
            pnlStatus.Controls.Add(dgvCart);
            pnlStatus.Controls.Add(btnLogOut);
            pnlStatus.Controls.Add(btnBuy);
            pnlStatus.CustomizableEdges = customizableEdges5;
            pnlStatus.Location = new Point(1143, 4);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlStatus.Size = new Size(343, 739);
            pnlStatus.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(96, 551);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(86, 22);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "TOTAL ALL:";
            // 
            // lblTotalAll
            // 
            lblTotalAll.BackColor = Color.Transparent;
            lblTotalAll.ForeColor = Color.White;
            lblTotalAll.Location = new Point(214, 551);
            lblTotalAll.Name = "lblTotalAll";
            lblTotalAll.Size = new Size(3, 2);
            lblTotalAll.TabIndex = 10;
            lblTotalAll.Text = null;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(3, 158);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(332, 377);
            dgvCart.TabIndex = 9;
            // 
            // tbpService
            // 
            tbpService.Location = new Point(184, 4);
            tbpService.Name = "tbpService";
            tbpService.Padding = new Padding(3);
            tbpService.Size = new Size(949, 739);
            tbpService.TabIndex = 5;
            tbpService.Text = "Service";
            tbpService.UseVisualStyleBackColor = true;
            // 
            // tbpDrinks
            // 
            tbpDrinks.Location = new Point(184, 4);
            tbpDrinks.Name = "tbpDrinks";
            tbpDrinks.Padding = new Padding(3);
            tbpDrinks.Size = new Size(949, 739);
            tbpDrinks.TabIndex = 1;
            tbpDrinks.Text = "Drinks";
            tbpDrinks.UseVisualStyleBackColor = true;
            // 
            // tbpFoods
            // 
            tbpFoods.AccessibleName = "";
            tbpFoods.Location = new Point(184, 4);
            tbpFoods.Name = "tbpFoods";
            tbpFoods.Padding = new Padding(3);
            tbpFoods.Size = new Size(949, 739);
            tbpFoods.TabIndex = 0;
            tbpFoods.Text = "Foods";
            tbpFoods.UseVisualStyleBackColor = true;
            // 
            // tbcUser
            // 
            tbcUser.AccessibleName = "";
            tbcUser.Alignment = TabAlignment.Left;
            tbcUser.Controls.Add(tbpFoods);
            tbcUser.Controls.Add(tbpDrinks);
            tbcUser.Controls.Add(tbpService);
            tbcUser.Dock = DockStyle.Left;
            tbcUser.ItemSize = new Size(180, 40);
            tbcUser.Location = new Point(0, 0);
            tbcUser.Name = "tbcUser";
            tbcUser.SelectedIndex = 0;
            tbcUser.Size = new Size(1137, 747);
            tbcUser.TabButtonHoverState.BorderColor = Color.Empty;
            tbcUser.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tbcUser.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tbcUser.TabButtonHoverState.ForeColor = Color.White;
            tbcUser.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tbcUser.TabButtonIdleState.BorderColor = Color.Empty;
            tbcUser.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tbcUser.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tbcUser.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tbcUser.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tbcUser.TabButtonSelectedState.BorderColor = Color.Empty;
            tbcUser.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tbcUser.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tbcUser.TabButtonSelectedState.ForeColor = Color.White;
            tbcUser.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tbcUser.TabButtonSize = new Size(180, 40);
            tbcUser.TabIndex = 0;
            tbcUser.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 747);
            Controls.Add(pnlStatus);
            Controls.Add(tbcUser);
            Name = "User";
            Text = "User";
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            tbcUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Panel pnlStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalAll;
        private DataGridView dgvCart;
        private TabPage tbpService;
        private TabPage tbpDrinks;
        private TabPage tbpFoods;
        private Guna.UI2.WinForms.Guna2TabControl tbcUser;
    }
}