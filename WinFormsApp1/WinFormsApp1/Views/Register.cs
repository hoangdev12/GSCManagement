using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Register : Form
    {
        private GcsmanagerContext _context;
        public Register()
        {
            _context = new GcsmanagerContext();
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPhoneNum.Text))
            {
                bool isExist = _context.Accounts.Any(p => p.Username == txtUserName.Text);
                if (!isExist)
                {
                    var newUser = new Account
                    {
                        Username = txtUserName.Text,
                        PasswordHash = txtPassword.Text,
                        Role = "Khách hàng",
                        Salt = "123",
                    };

                    _context.Accounts.Add(newUser);

                     _context.SaveChanges();
                    try
                    {
                        // Lưu Account trước để AccountId được khởi tạo


                        var newCustomer = new Customer
                        {
                            FullName = txtUserName.Text,
                            Phone = txtPhoneNum.Text,
                            AccountId = newUser.AccountId,
                        };

                        _context.Customers.Add(newCustomer);
                        _context.SaveChanges(); // Lưu Customer

                        MessageBox.Show("Tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tạo Account: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Account đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tên Account không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
