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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.Views
{
    public partial class Login : Form
    {
        private GcsmanagerContext _context = new GcsmanagerContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _context.Accounts.FirstOrDefault(u => u.Username == tbxUserName.Text && u.PasswordHash == tbxPass.Text);

            if (user != null)
            {
                MessageBox.Show("Dang nhap thanh cong!");
                // Đăng nhập thành công, mở form UserForm và đóng LoginFormssms
                User userForm = new User();
                userForm.Show();  // Mở form người dùng

                this.Hide();  // Ẩn form đăng nhập (LoginForm)
            } else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
