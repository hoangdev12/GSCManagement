﻿namespace WinFormsApp1.Views
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
            components = new System.ComponentModel.Container();
            tabAdmin = new TabControl();
            tbComputer = new TabPage();
            panel29 = new Panel();
            btnLogOut = new Button();
            panel32 = new Panel();
            txtTongTien = new TextBox();
            lblTongTien = new Label();
            panel31 = new Panel();
            txtConLai = new TextBox();
            lblConLai = new Label();
            panel30 = new Panel();
            txtDaChoi = new TextBox();
            lblDaChoi = new Label();
            txtStatus = new TextBox();
            flpComputers = new FlowLayoutPanel();
            tcAccount = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel13 = new Panel();
            txtAccountId = new TextBox();
            lblAccountId = new Label();
            panel15 = new Panel();
            txtAccountUserName = new TextBox();
            lblUserName = new Label();
            panel14 = new Panel();
            txtAccountPasswordHash = new TextBox();
            lblPasswordHash = new Label();
            panel16 = new Panel();
            txtAccountRole = new TextBox();
            lblRole = new Label();
            panel11 = new Panel();
            txtAccountActive = new TextBox();
            lblActive = new Label();
            panel12 = new Panel();
            txtAccountCreateDate = new TextBox();
            lblCreateDate = new Label();
            panel17 = new Panel();
            btnAccountEdit = new Button();
            btnAccountDelete = new Button();
            panel10 = new Panel();
            dgvAccount = new DataGridView();
            accountIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordHashDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saltDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isActiveDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource = new BindingSource(components);
            tcProduct = new TabPage();
            panel20 = new Panel();
            btnProductEdit = new Button();
            btnProductDelete = new Button();
            btnProductAdd = new Button();
            flpProduct = new FlowLayoutPanel();
            panel18 = new Panel();
            txtProductID = new TextBox();
            lblProducID = new Label();
            panel1 = new Panel();
            txtProductName = new TextBox();
            lblProductName = new Label();
            panel2 = new Panel();
            txtProductPrice = new TextBox();
            lblProductPrice = new Label();
            panel6 = new Panel();
            txtProductDes = new TextBox();
            lblProductDes = new Label();
            panel19 = new Panel();
            txtProductStockQuantity = new TextBox();
            lblProductStockQuantity = new Label();
            panel21 = new Panel();
            cbbProductCategory = new ComboBox();
            lblCategory = new Label();
            panel8 = new Panel();
            dgvProduct = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            tcCustomer = new TabPage();
            panel22 = new Panel();
            txtCustomerID = new TextBox();
            lblCustomerID = new Label();
            panel7 = new Panel();
            txtAccountName = new TextBox();
            lblAccountName = new Label();
            panel24 = new Panel();
            txtCusPhone = new TextBox();
            lblCusPhone = new Label();
            btnCusDelete = new Button();
            btnCusEdit = new Button();
            panel28 = new Panel();
            txtCusIsActive = new TextBox();
            lblCusIsActive = new Label();
            panel27 = new Panel();
            txtCusRegisterDate = new TextBox();
            lblCusRegisterDate = new Label();
            panel26 = new Panel();
            txtCusBalance = new TextBox();
            lblCusBalance = new Label();
            panel25 = new Panel();
            txtCusEmail = new TextBox();
            lblCusEmail = new Label();
            panel23 = new Panel();
            txtCusFullName = new TextBox();
            lblCusFullName = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dgvCustomer = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AccountName = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isActiveDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            tcCategories = new TabPage();
            btnCategoryDelete = new Button();
            btnCategoryEdit = new Button();
            btnCategoryAdd = new Button();
            panel5 = new Panel();
            txtCategoryDes = new TextBox();
            lblCategoryDes = new Label();
            panel4 = new Panel();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            panel3 = new Panel();
            txtCategoryId = new TextBox();
            lblCategoryId = new Label();
            dgvCategory = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            categoryBindingSource1 = new BindingSource(components);
            tcBooking = new TabPage();
            dgvBooking = new DataGridView();
            tcPayment = new TabPage();
            panel9 = new Panel();
            dgvPayment = new DataGridView();
            paymentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            paymentBindingSource = new BindingSource(components);
            Employee = new TabPage();
            tcService = new TabPage();
            tcServiceBooking = new TabPage();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            computerBindingSource = new BindingSource(components);
            tabAdmin.SuspendLayout();
            tbComputer.SuspendLayout();
            panel29.SuspendLayout();
            panel32.SuspendLayout();
            panel31.SuspendLayout();
            panel30.SuspendLayout();
            tcAccount.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel17.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            tcProduct.SuspendLayout();
            panel20.SuspendLayout();
            flpProduct.SuspendLayout();
            panel18.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel19.SuspendLayout();
            panel21.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tcCustomer.SuspendLayout();
            panel22.SuspendLayout();
            panel7.SuspendLayout();
            panel24.SuspendLayout();
            panel28.SuspendLayout();
            panel27.SuspendLayout();
            panel26.SuspendLayout();
            panel25.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            tcCategories.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            tcBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            tcPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tbComputer);
            tabAdmin.Controls.Add(tcAccount);
            tabAdmin.Controls.Add(tcProduct);
            tabAdmin.Controls.Add(tcCustomer);
            tabAdmin.Controls.Add(tcCategories);
            tabAdmin.Controls.Add(tcBooking);
            tabAdmin.Controls.Add(tcPayment);
            tabAdmin.Controls.Add(Employee);
            tabAdmin.Controls.Add(tcService);
            tabAdmin.Controls.Add(tcServiceBooking);
            tabAdmin.Location = new Point(12, 12);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(963, 460);
            tabAdmin.TabIndex = 3;
            // 
            // tbComputer
            // 
            tbComputer.AutoScroll = true;
            tbComputer.Controls.Add(panel29);
            tbComputer.Controls.Add(flpComputers);
            tbComputer.Location = new Point(4, 29);
            tbComputer.Name = "tbComputer";
            tbComputer.Padding = new Padding(3);
            tbComputer.Size = new Size(955, 427);
            tbComputer.TabIndex = 0;
            tbComputer.Text = "Computer";
            tbComputer.UseVisualStyleBackColor = true;
            // 
            // panel29
            // 
            panel29.Controls.Add(btnLogOut);
            panel29.Controls.Add(panel32);
            panel29.Controls.Add(panel31);
            panel29.Controls.Add(panel30);
            panel29.Controls.Add(txtStatus);
            panel29.Location = new Point(675, 5);
            panel29.Name = "panel29";
            panel29.Size = new Size(274, 416);
            panel29.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(120, 318);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(146, 29);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel32
            // 
            panel32.Controls.Add(txtTongTien);
            panel32.Controls.Add(lblTongTien);
            panel32.Location = new Point(3, 219);
            panel32.Name = "panel32";
            panel32.Size = new Size(263, 46);
            panel32.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(94, 10);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(165, 27);
            txtTongTien.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(11, 12);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 20);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền";
            // 
            // panel31
            // 
            panel31.Controls.Add(txtConLai);
            panel31.Controls.Add(lblConLai);
            panel31.Location = new Point(3, 139);
            panel31.Name = "panel31";
            panel31.Size = new Size(263, 46);
            panel31.TabIndex = 2;
            // 
            // txtConLai
            // 
            txtConLai.Location = new Point(94, 10);
            txtConLai.Name = "txtConLai";
            txtConLai.Size = new Size(165, 27);
            txtConLai.TabIndex = 1;
            // 
            // lblConLai
            // 
            lblConLai.AutoSize = true;
            lblConLai.Location = new Point(11, 12);
            lblConLai.Name = "lblConLai";
            lblConLai.Size = new Size(55, 20);
            lblConLai.TabIndex = 0;
            lblConLai.Text = "Còn lại";
            // 
            // panel30
            // 
            panel30.Controls.Add(txtDaChoi);
            panel30.Controls.Add(lblDaChoi);
            panel30.Location = new Point(3, 68);
            panel30.Name = "panel30";
            panel30.Size = new Size(263, 46);
            panel30.TabIndex = 1;
            // 
            // txtDaChoi
            // 
            txtDaChoi.Location = new Point(94, 10);
            txtDaChoi.Name = "txtDaChoi";
            txtDaChoi.Size = new Size(165, 27);
            txtDaChoi.TabIndex = 1;
            // 
            // lblDaChoi
            // 
            lblDaChoi.AutoSize = true;
            lblDaChoi.Location = new Point(11, 12);
            lblDaChoi.Name = "lblDaChoi";
            lblDaChoi.Size = new Size(60, 20);
            lblDaChoi.TabIndex = 0;
            lblDaChoi.Text = "Đã chơi";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(16, 20);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(246, 27);
            txtStatus.TabIndex = 0;
            // 
            // flpComputers
            // 
            flpComputers.Location = new Point(5, 5);
            flpComputers.Name = "flpComputers";
            flpComputers.Size = new Size(663, 416);
            flpComputers.TabIndex = 0;
            // 
            // tcAccount
            // 
            tcAccount.Controls.Add(flowLayoutPanel1);
            tcAccount.Controls.Add(panel10);
            tcAccount.Location = new Point(4, 29);
            tcAccount.Name = "tcAccount";
            tcAccount.Padding = new Padding(3);
            tcAccount.Size = new Size(955, 427);
            tcAccount.TabIndex = 1;
            tcAccount.Text = "Account";
            tcAccount.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(panel15);
            flowLayoutPanel1.Controls.Add(panel14);
            flowLayoutPanel1.Controls.Add(panel16);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(panel12);
            flowLayoutPanel1.Controls.Add(panel17);
            flowLayoutPanel1.Location = new Point(508, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(442, 415);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.Controls.Add(txtAccountId);
            panel13.Controls.Add(lblAccountId);
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(444, 49);
            panel13.TabIndex = 5;
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(188, 10);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.ReadOnly = true;
            txtAccountId.Size = new Size(125, 27);
            txtAccountId.TabIndex = 1;
            // 
            // lblAccountId
            // 
            lblAccountId.AutoSize = true;
            lblAccountId.Location = new Point(3, 13);
            lblAccountId.Name = "lblAccountId";
            lblAccountId.Size = new Size(81, 20);
            lblAccountId.TabIndex = 0;
            lblAccountId.Text = "AccountID:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txtAccountUserName);
            panel15.Controls.Add(lblUserName);
            panel15.Location = new Point(3, 58);
            panel15.Name = "panel15";
            panel15.Size = new Size(444, 49);
            panel15.TabIndex = 5;
            // 
            // txtAccountUserName
            // 
            txtAccountUserName.Location = new Point(188, 10);
            txtAccountUserName.Name = "txtAccountUserName";
            txtAccountUserName.ReadOnly = true;
            txtAccountUserName.Size = new Size(125, 27);
            txtAccountUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(3, 13);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName:";
            // 
            // panel14
            // 
            panel14.Controls.Add(txtAccountPasswordHash);
            panel14.Controls.Add(lblPasswordHash);
            panel14.Location = new Point(3, 113);
            panel14.Name = "panel14";
            panel14.Size = new Size(444, 49);
            panel14.TabIndex = 9;
            // 
            // txtAccountPasswordHash
            // 
            txtAccountPasswordHash.Location = new Point(188, 10);
            txtAccountPasswordHash.Name = "txtAccountPasswordHash";
            txtAccountPasswordHash.ReadOnly = true;
            txtAccountPasswordHash.Size = new Size(125, 27);
            txtAccountPasswordHash.TabIndex = 3;
            // 
            // lblPasswordHash
            // 
            lblPasswordHash.AutoSize = true;
            lblPasswordHash.Location = new Point(3, 13);
            lblPasswordHash.Name = "lblPasswordHash";
            lblPasswordHash.Size = new Size(106, 20);
            lblPasswordHash.TabIndex = 0;
            lblPasswordHash.Text = "PasswordHash:";
            // 
            // panel16
            // 
            panel16.Controls.Add(txtAccountRole);
            panel16.Controls.Add(lblRole);
            panel16.Location = new Point(3, 168);
            panel16.Name = "panel16";
            panel16.Size = new Size(444, 49);
            panel16.TabIndex = 4;
            // 
            // txtAccountRole
            // 
            txtAccountRole.Location = new Point(188, 10);
            txtAccountRole.Name = "txtAccountRole";
            txtAccountRole.ReadOnly = true;
            txtAccountRole.Size = new Size(125, 27);
            txtAccountRole.TabIndex = 4;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(3, 13);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 20);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role:";
            // 
            // panel11
            // 
            panel11.Controls.Add(txtAccountActive);
            panel11.Controls.Add(lblActive);
            panel11.Location = new Point(3, 223);
            panel11.Name = "panel11";
            panel11.Size = new Size(444, 49);
            panel11.TabIndex = 5;
            // 
            // txtAccountActive
            // 
            txtAccountActive.Location = new Point(188, 10);
            txtAccountActive.Name = "txtAccountActive";
            txtAccountActive.ReadOnly = true;
            txtAccountActive.Size = new Size(125, 27);
            txtAccountActive.TabIndex = 5;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 13);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(53, 20);
            lblActive.TabIndex = 0;
            lblActive.Text = "Active:";
            // 
            // panel12
            // 
            panel12.Controls.Add(txtAccountCreateDate);
            panel12.Controls.Add(lblCreateDate);
            panel12.Location = new Point(3, 278);
            panel12.Name = "panel12";
            panel12.Size = new Size(444, 49);
            panel12.TabIndex = 5;
            // 
            // txtAccountCreateDate
            // 
            txtAccountCreateDate.Location = new Point(188, 10);
            txtAccountCreateDate.Name = "txtAccountCreateDate";
            txtAccountCreateDate.ReadOnly = true;
            txtAccountCreateDate.Size = new Size(125, 27);
            txtAccountCreateDate.TabIndex = 6;
            // 
            // lblCreateDate
            // 
            lblCreateDate.AutoSize = true;
            lblCreateDate.Location = new Point(3, 13);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(91, 20);
            lblCreateDate.TabIndex = 0;
            lblCreateDate.Text = "Create Date:";
            // 
            // panel17
            // 
            panel17.Controls.Add(btnAccountEdit);
            panel17.Controls.Add(btnAccountDelete);
            panel17.Location = new Point(3, 333);
            panel17.Name = "panel17";
            panel17.Size = new Size(438, 74);
            panel17.TabIndex = 6;
            // 
            // btnAccountEdit
            // 
            btnAccountEdit.Location = new Point(178, 13);
            btnAccountEdit.Name = "btnAccountEdit";
            btnAccountEdit.Size = new Size(103, 40);
            btnAccountEdit.TabIndex = 7;
            btnAccountEdit.Text = "Edit";
            btnAccountEdit.Click += btnAccountEdit_Click;
            // 
            // btnAccountDelete
            // 
            btnAccountDelete.Location = new Point(305, 13);
            btnAccountDelete.Name = "btnAccountDelete";
            btnAccountDelete.Size = new Size(103, 40);
            btnAccountDelete.TabIndex = 8;
            btnAccountDelete.Text = "Delete";
            btnAccountDelete.Click += btnAccountDelete_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(dgvAccount);
            panel10.Location = new Point(6, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(496, 415);
            panel10.TabIndex = 0;
            // 
            // dgvAccount
            // 
            dgvAccount.AutoGenerateColumns = false;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { accountIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordHashDataGridViewTextBoxColumn, saltDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, isActiveDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn });
            dgvAccount.DataSource = accountBindingSource;
            dgvAccount.Location = new Point(3, 3);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.Size = new Size(490, 409);
            dgvAccount.TabIndex = 0;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            accountIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            accountIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            passwordHashDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            passwordHashDataGridViewTextBoxColumn.Width = 125;
            // 
            // saltDataGridViewTextBoxColumn
            // 
            saltDataGridViewTextBoxColumn.DataPropertyName = "Salt";
            saltDataGridViewTextBoxColumn.HeaderText = "Salt";
            saltDataGridViewTextBoxColumn.MinimumWidth = 6;
            saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            saltDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewTextBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            createDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            createDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Models.Account);
            // 
            // tcProduct
            // 
            tcProduct.Controls.Add(panel20);
            tcProduct.Controls.Add(flpProduct);
            tcProduct.Controls.Add(panel8);
            tcProduct.Location = new Point(4, 29);
            tcProduct.Name = "tcProduct";
            tcProduct.Size = new Size(955, 427);
            tcProduct.TabIndex = 2;
            tcProduct.Text = "Product";
            tcProduct.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnProductEdit);
            panel20.Controls.Add(btnProductDelete);
            panel20.Controls.Add(btnProductAdd);
            panel20.Location = new Point(636, 321);
            panel20.Name = "panel20";
            panel20.Size = new Size(314, 100);
            panel20.TabIndex = 2;
            // 
            // btnProductEdit
            // 
            btnProductEdit.Location = new Point(106, 32);
            btnProductEdit.Name = "btnProductEdit";
            btnProductEdit.Size = new Size(94, 38);
            btnProductEdit.TabIndex = 8;
            btnProductEdit.Text = "Edit";
            btnProductEdit.UseVisualStyleBackColor = true;
            btnProductEdit.Click += btnProductEdit_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(206, 32);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(94, 38);
            btnProductDelete.TabIndex = 9;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(6, 32);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(94, 38);
            btnProductAdd.TabIndex = 7;
            btnProductAdd.Text = "Add";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // flpProduct
            // 
            flpProduct.Controls.Add(panel18);
            flpProduct.Controls.Add(panel1);
            flpProduct.Controls.Add(panel2);
            flpProduct.Controls.Add(panel6);
            flpProduct.Controls.Add(panel19);
            flpProduct.Controls.Add(panel21);
            flpProduct.Location = new Point(636, 6);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(314, 309);
            flpProduct.TabIndex = 1;
            // 
            // panel18
            // 
            panel18.Controls.Add(txtProductID);
            panel18.Controls.Add(lblProducID);
            panel18.Location = new Point(3, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(305, 45);
            panel18.TabIndex = 1;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(141, 8);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(135, 27);
            txtProductID.TabIndex = 1;
            // 
            // lblProducID
            // 
            lblProducID.AutoSize = true;
            lblProducID.Location = new Point(3, 11);
            lblProducID.Name = "lblProducID";
            lblProducID.Size = new Size(78, 20);
            lblProducID.TabIndex = 0;
            lblProducID.Text = "ProductID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(lblProductName);
            panel1.Location = new Point(3, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 45);
            panel1.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(141, 8);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(135, 27);
            txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(3, 11);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "ProductName:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtProductPrice);
            panel2.Controls.Add(lblProductPrice);
            panel2.Location = new Point(3, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 45);
            panel2.TabIndex = 3;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(141, 8);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.ReadOnly = true;
            txtProductPrice.Size = new Size(135, 27);
            txtProductPrice.TabIndex = 3;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(3, 11);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(44, 20);
            lblProductPrice.TabIndex = 0;
            lblProductPrice.Text = "Price:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtProductDes);
            panel6.Controls.Add(lblProductDes);
            panel6.Location = new Point(3, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 45);
            panel6.TabIndex = 4;
            // 
            // txtProductDes
            // 
            txtProductDes.Location = new Point(141, 8);
            txtProductDes.Name = "txtProductDes";
            txtProductDes.ReadOnly = true;
            txtProductDes.Size = new Size(135, 27);
            txtProductDes.TabIndex = 4;
            // 
            // lblProductDes
            // 
            lblProductDes.AutoSize = true;
            lblProductDes.Location = new Point(3, 11);
            lblProductDes.Name = "lblProductDes";
            lblProductDes.Size = new Size(139, 20);
            lblProductDes.TabIndex = 0;
            lblProductDes.Text = "ProductDescription:";
            // 
            // panel19
            // 
            panel19.Controls.Add(txtProductStockQuantity);
            panel19.Controls.Add(lblProductStockQuantity);
            panel19.Location = new Point(3, 207);
            panel19.Name = "panel19";
            panel19.Size = new Size(305, 45);
            panel19.TabIndex = 5;
            // 
            // txtProductStockQuantity
            // 
            txtProductStockQuantity.Location = new Point(141, 8);
            txtProductStockQuantity.Name = "txtProductStockQuantity";
            txtProductStockQuantity.ReadOnly = true;
            txtProductStockQuantity.Size = new Size(135, 27);
            txtProductStockQuantity.TabIndex = 5;
            // 
            // lblProductStockQuantity
            // 
            lblProductStockQuantity.AutoSize = true;
            lblProductStockQuantity.Location = new Point(3, 11);
            lblProductStockQuantity.Name = "lblProductStockQuantity";
            lblProductStockQuantity.Size = new Size(104, 20);
            lblProductStockQuantity.TabIndex = 0;
            lblProductStockQuantity.Text = "StockQuantity:";
            // 
            // panel21
            // 
            panel21.Controls.Add(cbbProductCategory);
            panel21.Controls.Add(lblCategory);
            panel21.Location = new Point(3, 258);
            panel21.Name = "panel21";
            panel21.Size = new Size(305, 45);
            panel21.TabIndex = 6;
            // 
            // cbbProductCategory
            // 
            cbbProductCategory.FormatString = "N0";
            cbbProductCategory.FormattingEnabled = true;
            cbbProductCategory.Location = new Point(141, 8);
            cbbProductCategory.Name = "cbbProductCategory";
            cbbProductCategory.Size = new Size(135, 28);
            cbbProductCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(3, 11);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvProduct);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(630, 421);
            panel8.TabIndex = 0;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, stockQuantityDataGridViewTextBoxColumn, CategoryId });
            dgvProduct.DataSource = productBindingSource;
            dgvProduct.Location = new Point(3, 3);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(624, 415);
            dgvProduct.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            stockQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // tcCustomer
            // 
            tcCustomer.Controls.Add(panel22);
            tcCustomer.Controls.Add(panel7);
            tcCustomer.Controls.Add(panel24);
            tcCustomer.Controls.Add(btnCusDelete);
            tcCustomer.Controls.Add(btnCusEdit);
            tcCustomer.Controls.Add(panel28);
            tcCustomer.Controls.Add(panel27);
            tcCustomer.Controls.Add(panel26);
            tcCustomer.Controls.Add(panel25);
            tcCustomer.Controls.Add(panel23);
            tcCustomer.Controls.Add(flowLayoutPanel2);
            tcCustomer.Controls.Add(dgvCustomer);
            tcCustomer.Location = new Point(4, 29);
            tcCustomer.Name = "tcCustomer";
            tcCustomer.Size = new Size(955, 427);
            tcCustomer.TabIndex = 3;
            tcCustomer.Text = "Customer";
            tcCustomer.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            panel22.Controls.Add(txtCustomerID);
            panel22.Controls.Add(lblCustomerID);
            panel22.Location = new Point(644, 12);
            panel22.Name = "panel22";
            panel22.Size = new Size(306, 41);
            panel22.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(127, 10);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(152, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(3, 13);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(90, 20);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "CustomerID:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtAccountName);
            panel7.Controls.Add(lblAccountName);
            panel7.Location = new Point(644, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(306, 41);
            panel7.TabIndex = 3;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(127, 10);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.ReadOnly = true;
            txtAccountName.Size = new Size(152, 27);
            txtAccountName.TabIndex = 1;
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.Location = new Point(3, 13);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(66, 20);
            lblAccountName.TabIndex = 0;
            lblAccountName.Text = "Account:";
            // 
            // panel24
            // 
            panel24.Controls.Add(txtCusPhone);
            panel24.Controls.Add(lblCusPhone);
            panel24.Location = new Point(644, 153);
            panel24.Name = "panel24";
            panel24.Size = new Size(306, 41);
            panel24.TabIndex = 2;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Location = new Point(127, 10);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.ReadOnly = true;
            txtCusPhone.Size = new Size(152, 27);
            txtCusPhone.TabIndex = 1;
            // 
            // lblCusPhone
            // 
            lblCusPhone.AutoSize = true;
            lblCusPhone.Location = new Point(3, 13);
            lblCusPhone.Name = "lblCusPhone";
            lblCusPhone.Size = new Size(53, 20);
            lblCusPhone.TabIndex = 0;
            lblCusPhone.Text = "Phone:";
            // 
            // btnCusDelete
            // 
            btnCusDelete.Location = new Point(818, 388);
            btnCusDelete.Name = "btnCusDelete";
            btnCusDelete.Size = new Size(94, 29);
            btnCusDelete.TabIndex = 5;
            btnCusDelete.Text = "Delete";
            btnCusDelete.UseVisualStyleBackColor = true;
            // 
            // btnCusEdit
            // 
            btnCusEdit.Location = new Point(687, 388);
            btnCusEdit.Name = "btnCusEdit";
            btnCusEdit.Size = new Size(94, 29);
            btnCusEdit.TabIndex = 4;
            btnCusEdit.Text = "Edit";
            btnCusEdit.UseVisualStyleBackColor = true;
            btnCusEdit.Click += btnCusEdit_Click;
            // 
            // panel28
            // 
            panel28.Controls.Add(txtCusIsActive);
            panel28.Controls.Add(lblCusIsActive);
            panel28.Location = new Point(644, 341);
            panel28.Name = "panel28";
            panel28.Size = new Size(306, 41);
            panel28.TabIndex = 3;
            // 
            // txtCusIsActive
            // 
            txtCusIsActive.Location = new Point(127, 10);
            txtCusIsActive.Name = "txtCusIsActive";
            txtCusIsActive.ReadOnly = true;
            txtCusIsActive.Size = new Size(152, 27);
            txtCusIsActive.TabIndex = 1;
            // 
            // lblCusIsActive
            // 
            lblCusIsActive.AutoSize = true;
            lblCusIsActive.Location = new Point(3, 13);
            lblCusIsActive.Name = "lblCusIsActive";
            lblCusIsActive.Size = new Size(53, 20);
            lblCusIsActive.TabIndex = 0;
            lblCusIsActive.Text = "Active:";
            // 
            // panel27
            // 
            panel27.Controls.Add(txtCusRegisterDate);
            panel27.Controls.Add(lblCusRegisterDate);
            panel27.Location = new Point(644, 294);
            panel27.Name = "panel27";
            panel27.Size = new Size(306, 41);
            panel27.TabIndex = 2;
            // 
            // txtCusRegisterDate
            // 
            txtCusRegisterDate.Location = new Point(127, 10);
            txtCusRegisterDate.Name = "txtCusRegisterDate";
            txtCusRegisterDate.ReadOnly = true;
            txtCusRegisterDate.Size = new Size(152, 27);
            txtCusRegisterDate.TabIndex = 3;
            // 
            // lblCusRegisterDate
            // 
            lblCusRegisterDate.AutoSize = true;
            lblCusRegisterDate.Location = new Point(3, 13);
            lblCusRegisterDate.Name = "lblCusRegisterDate";
            lblCusRegisterDate.Size = new Size(98, 20);
            lblCusRegisterDate.TabIndex = 3;
            lblCusRegisterDate.Text = "RegisterDate:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txtCusBalance);
            panel26.Controls.Add(lblCusBalance);
            panel26.Location = new Point(644, 247);
            panel26.Name = "panel26";
            panel26.Size = new Size(306, 41);
            panel26.TabIndex = 2;
            // 
            // txtCusBalance
            // 
            txtCusBalance.Location = new Point(127, 10);
            txtCusBalance.Name = "txtCusBalance";
            txtCusBalance.ReadOnly = true;
            txtCusBalance.Size = new Size(152, 27);
            txtCusBalance.TabIndex = 2;
            // 
            // lblCusBalance
            // 
            lblCusBalance.AutoSize = true;
            lblCusBalance.Location = new Point(3, 13);
            lblCusBalance.Name = "lblCusBalance";
            lblCusBalance.Size = new Size(64, 20);
            lblCusBalance.TabIndex = 0;
            lblCusBalance.Text = "Balance:";
            // 
            // panel25
            // 
            panel25.Controls.Add(txtCusEmail);
            panel25.Controls.Add(lblCusEmail);
            panel25.Location = new Point(644, 200);
            panel25.Name = "panel25";
            panel25.Size = new Size(306, 41);
            panel25.TabIndex = 2;
            // 
            // txtCusEmail
            // 
            txtCusEmail.Location = new Point(127, 10);
            txtCusEmail.Name = "txtCusEmail";
            txtCusEmail.ReadOnly = true;
            txtCusEmail.Size = new Size(152, 27);
            txtCusEmail.TabIndex = 2;
            // 
            // lblCusEmail
            // 
            lblCusEmail.AutoSize = true;
            lblCusEmail.Location = new Point(3, 13);
            lblCusEmail.Name = "lblCusEmail";
            lblCusEmail.Size = new Size(49, 20);
            lblCusEmail.TabIndex = 0;
            lblCusEmail.Text = "Email:";
            // 
            // panel23
            // 
            panel23.Controls.Add(txtCusFullName);
            panel23.Controls.Add(lblCusFullName);
            panel23.Location = new Point(644, 106);
            panel23.Name = "panel23";
            panel23.Size = new Size(306, 41);
            panel23.TabIndex = 2;
            // 
            // txtCusFullName
            // 
            txtCusFullName.Location = new Point(127, 10);
            txtCusFullName.Name = "txtCusFullName";
            txtCusFullName.ReadOnly = true;
            txtCusFullName.Size = new Size(152, 27);
            txtCusFullName.TabIndex = 1;
            // 
            // lblCusFullName
            // 
            lblCusFullName.AutoSize = true;
            lblCusFullName.Location = new Point(3, 13);
            lblCusFullName.Name = "lblCusFullName";
            lblCusFullName.Size = new Size(75, 20);
            lblCusFullName.TabIndex = 0;
            lblCusFullName.Text = "FullName:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(644, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(306, 379);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, AccountName, fullNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn, registerDateDataGridViewTextBoxColumn, isActiveDataGridViewTextBoxColumn1 });
            dgvCustomer.DataSource = customerBindingSource;
            dgvCustomer.Location = new Point(3, 3);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(635, 428);
            dgvCustomer.TabIndex = 0;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // AccountName
            // 
            AccountName.DataPropertyName = "AccountName";
            AccountName.HeaderText = "AccountName";
            AccountName.MinimumWidth = 6;
            AccountName.Name = "AccountName";
            AccountName.ReadOnly = true;
            AccountName.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            registerDateDataGridViewTextBoxColumn.HeaderText = "RegisterDate";
            registerDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            registerDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn1
            // 
            isActiveDataGridViewTextBoxColumn1.DataPropertyName = "IsActive";
            isActiveDataGridViewTextBoxColumn1.HeaderText = "IsActive";
            isActiveDataGridViewTextBoxColumn1.MinimumWidth = 6;
            isActiveDataGridViewTextBoxColumn1.Name = "isActiveDataGridViewTextBoxColumn1";
            isActiveDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // tcCategories
            // 
            tcCategories.Controls.Add(btnCategoryDelete);
            tcCategories.Controls.Add(btnCategoryEdit);
            tcCategories.Controls.Add(btnCategoryAdd);
            tcCategories.Controls.Add(panel5);
            tcCategories.Controls.Add(panel4);
            tcCategories.Controls.Add(panel3);
            tcCategories.Controls.Add(dgvCategory);
            tcCategories.Location = new Point(4, 29);
            tcCategories.Name = "tcCategories";
            tcCategories.Size = new Size(955, 427);
            tcCategories.TabIndex = 4;
            tcCategories.Text = "Categories";
            tcCategories.UseVisualStyleBackColor = true;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.Location = new Point(829, 266);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(94, 29);
            btnCategoryDelete.TabIndex = 7;
            btnCategoryDelete.Text = "Delete";
            btnCategoryDelete.UseVisualStyleBackColor = true;
            btnCategoryDelete.Click += btnCategoryDelete_Click;
            // 
            // btnCategoryEdit
            // 
            btnCategoryEdit.Location = new Point(709, 266);
            btnCategoryEdit.Name = "btnCategoryEdit";
            btnCategoryEdit.Size = new Size(94, 29);
            btnCategoryEdit.TabIndex = 6;
            btnCategoryEdit.Text = "Edit";
            btnCategoryEdit.UseVisualStyleBackColor = true;
            btnCategoryEdit.Click += btnCategoryEdit_Click;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Location = new Point(588, 266);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(94, 29);
            btnCategoryAdd.TabIndex = 5;
            btnCategoryAdd.Text = "Add";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtCategoryDes);
            panel5.Controls.Add(lblCategoryDes);
            panel5.Location = new Point(557, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(398, 50);
            panel5.TabIndex = 3;
            // 
            // txtCategoryDes
            // 
            txtCategoryDes.Location = new Point(220, 10);
            txtCategoryDes.Name = "txtCategoryDes";
            txtCategoryDes.ReadOnly = true;
            txtCategoryDes.Size = new Size(151, 27);
            txtCategoryDes.TabIndex = 3;
            // 
            // lblCategoryDes
            // 
            lblCategoryDes.AutoSize = true;
            lblCategoryDes.Location = new Point(13, 13);
            lblCategoryDes.Name = "lblCategoryDes";
            lblCategoryDes.Size = new Size(88, 20);
            lblCategoryDes.TabIndex = 0;
            lblCategoryDes.Text = "Description:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtCategoryName);
            panel4.Controls.Add(lblCategoryName);
            panel4.Location = new Point(557, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(398, 50);
            panel4.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(220, 10);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.ReadOnly = true;
            txtCategoryName.Size = new Size(151, 27);
            txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(13, 13);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(112, 20);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "CategoryName:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCategoryId);
            panel3.Controls.Add(lblCategoryId);
            panel3.Location = new Point(557, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 50);
            panel3.TabIndex = 2;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(220, 10);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(151, 27);
            txtCategoryId.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(13, 13);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(87, 20);
            lblCategoryId.TabIndex = 0;
            lblCategoryId.Text = "CategoryID:";
            // 
            // dgvCategory
            // 
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvCategory.DataSource = categoryBindingSource1;
            dgvCategory.Location = new Point(3, 3);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(548, 421);
            dgvCategory.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "CategoryId";
            dataGridViewTextBoxColumn5.HeaderText = "CategoryId";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.DataPropertyName = "CategoryName";
            dataGridViewTextBoxColumn6.HeaderText = "CategoryName";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            dataGridViewTextBoxColumn7.HeaderText = "Description";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Models.Category);
            // 
            // tcBooking
            // 
            tcBooking.Controls.Add(dgvBooking);
            tcBooking.Location = new Point(4, 29);
            tcBooking.Name = "tcBooking";
            tcBooking.Size = new Size(955, 427);
            tcBooking.TabIndex = 5;
            tcBooking.Text = "Booking";
            tcBooking.UseVisualStyleBackColor = true;
            // 
            // dgvBooking
            // 
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Dock = DockStyle.Fill;
            dgvBooking.Location = new Point(0, 0);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.RowHeadersWidth = 51;
            dgvBooking.Size = new Size(955, 427);
            dgvBooking.TabIndex = 0;
            // 
            // tcPayment
            // 
            tcPayment.Controls.Add(panel9);
            tcPayment.Controls.Add(dgvPayment);
            tcPayment.Location = new Point(4, 29);
            tcPayment.Name = "tcPayment";
            tcPayment.Size = new Size(955, 427);
            tcPayment.TabIndex = 6;
            tcPayment.Text = "Payment";
            tcPayment.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Location = new Point(709, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(241, 421);
            panel9.TabIndex = 1;
            // 
            // dgvPayment
            // 
            dgvPayment.AutoGenerateColumns = false;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Columns.AddRange(new DataGridViewColumn[] { paymentIdDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn1, amountDataGridViewTextBoxColumn, paymentDateDataGridViewTextBoxColumn, paymentMethodDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn1 });
            dgvPayment.DataSource = paymentBindingSource;
            dgvPayment.Location = new Point(3, 3);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.Size = new Size(700, 421);
            dgvPayment.TabIndex = 0;
            // 
            // paymentIdDataGridViewTextBoxColumn
            // 
            paymentIdDataGridViewTextBoxColumn.DataPropertyName = "PaymentId";
            paymentIdDataGridViewTextBoxColumn.HeaderText = "PaymentId";
            paymentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentIdDataGridViewTextBoxColumn.Name = "paymentIdDataGridViewTextBoxColumn";
            paymentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn1
            // 
            customerIdDataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn1.Name = "customerIdDataGridViewTextBoxColumn1";
            customerIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            paymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            paymentMethodDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            customerDataGridViewTextBoxColumn1.Width = 125;
            // 
            // paymentBindingSource
            // 
            paymentBindingSource.DataSource = typeof(Models.Payment);
            // 
            // Employee
            // 
            Employee.Location = new Point(4, 29);
            Employee.Name = "Employee";
            Employee.Size = new Size(955, 427);
            Employee.TabIndex = 8;
            Employee.Text = "Employee";
            Employee.UseVisualStyleBackColor = true;
            // 
            // tcService
            // 
            tcService.Location = new Point(4, 29);
            tcService.Name = "tcService";
            tcService.Size = new Size(955, 427);
            tcService.TabIndex = 9;
            tcService.Text = "Service";
            tcService.UseVisualStyleBackColor = true;
            // 
            // tcServiceBooking
            // 
            tcServiceBooking.Location = new Point(4, 29);
            tcServiceBooking.Name = "tcServiceBooking";
            tcServiceBooking.Size = new Size(955, 427);
            tcServiceBooking.TabIndex = 10;
            tcServiceBooking.Text = "ServiceBooking";
            tcServiceBooking.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 0;
            // 
            // computerBindingSource
            // 
            computerBindingSource.DataSource = typeof(Models.Computer);
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 478);
            Controls.Add(tabAdmin);
            Name = "Admin";
            Text = "AdminAccount";
            tabAdmin.ResumeLayout(false);
            tbComputer.ResumeLayout(false);
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            tcAccount.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel17.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            tcProduct.ResumeLayout(false);
            panel20.ResumeLayout(false);
            flpProduct.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tcCustomer.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            tcCategories.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            tcBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            tcPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdmin;
        private TabPage tcAccount;
        private TabPage tcProduct;
        private TabPage tcCategories;
        private TabPage tcBooking;
        private TabPage tcPayment;
        private TabPage Employee;
        private TabPage tcCustomer;
        private BindingSource computerBindingSource;
        private DataGridView dgvBooking;
        private DataGridViewTextBoxColumn bookingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn computerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingServicesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn computerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private Panel panel9;
        private DataGridView dgvPayment;
        private DataGridViewTextBoxColumn paymentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private BindingSource paymentBindingSource;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel10;
        private DataGridView dgvAccount;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private Panel panel15;
        private TextBox txtAccountUserName;
        private Label lblUserName;
        private Panel panel14;
        private TextBox txtAccountPasswordHash;
        private Label lblPasswordHash;
        private Panel panel16;
        private TextBox txtAccountRole;
        private Label lblRole;
        private Panel panel11;
        private TextBox txtAccountActive;
        private Label lblActive;
        private Panel panel12;
        private TextBox txtAccountCreateDate;
        private Label lblCreateDate;
        private Panel panel13;
        private TextBox txtAccountId;
        private Label lblAccountId;
        private Panel panel17;
        private Button btnAccountEdit;
        private Button btnAccountDelete;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bookingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentsDataGridViewTextBoxColumn;
        private BindingSource bindingSource2;
        private Panel panel2;
        private DataGridView dgvCategory;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private Panel panel6;
        private TextBox txtProductDes;
        
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TabPage tbComputer;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel5;
        private TextBox txtCategoryDes;
        private Label lblCategoryDes;
        private Panel panel4;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private Panel panel3;
        private TextBox txtCategoryId;
        private Label lblCategoryId;
        private Button btnCategoryDelete;
        private Button btnCategoryEdit;
        private Button btnCategoryAdd;
        private BindingSource bindingSource4;
        private Panel panel8;
        private DataGridView dgvProduct;
        private BindingSource productBindingSource;
        private FlowLayoutPanel flpProduct;
        private Panel panel18;
        private TextBox txtProductID;
        private Label lblProducID;
        private Panel panel1;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtProductPrice;
        private Label lblProductPrice;
        private Label lblProductDes;
        private Panel panel19;
        private TextBox txtProductStockQuantity;
        private Label lblProductStockQuantity;
        private Panel panel20;
        private Button button3;
        private Button button2;
        private Button btnProductAdd;
        private Button btnProductDelete;
        private Button btnProductEdit;
        private Panel panel21;
        private Label lblCategory;
        private ComboBox cbbProductCategory;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel27;
        private TextBox textBox8;
        private Label label7;
        private Panel panel26;
        private TextBox textBox7;
        private Label lblCusBalance;
        private Panel panel25;
        private TextBox textBox6;
        private Label lblCusEmail;
        private Panel panel24;
        private TextBox txtCusPhone;
        private Label lblCusPhone;
        private Panel panel23;
        private TextBox txtCusFullName;
        private Label lblCusFullName;
        private Panel panel22;
        private TextBox txtCustomerID;
        private Label lblCustomerID;
        private Button btnCusDelete;
        private Button btnCusEdit;
        private Panel panel28;
        private TextBox txtCusIsActive;
        private Label lblCusIsActive;
        private TextBox txtCusRegisterDate;
        private Label lblCusRegisterDate;
        private TextBox txtCusBalance;
        private TextBox txtCusEmail;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Panel panel7;
        private TextBox txtAccountName;
        private Label lblAccountName;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AccountName;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn1;
        private Panel panel29;
        private Panel panel32;
        private TextBox txtTongTien;
        private Label lblTongTien;
        private Panel panel31;
        private TextBox txtConLai;
        private Label lblConLai;
        private Panel panel30;
        private TextBox txtDaChoi;
        private Label lblDaChoi;
        private TextBox txtStatus;
        private FlowLayoutPanel flpComputers;
        private Button btnLogOut;
        private TabPage tcService;
        private TabPage tcServiceBooking;
    }
}