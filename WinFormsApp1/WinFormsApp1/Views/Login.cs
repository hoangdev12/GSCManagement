using Microsoft.Identity.Client;
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
        private Computer? selectedComputer; // Biến lưu trữ máy tính được chọn
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _context.Accounts.FirstOrDefault(u => u.Username == tbxUserName.Text && u.PasswordHash == tbxPass.Text && u.IsActive == true);

            if (user != null)
            {
                Random random = new Random();
                int result = random.Next(1, 5); // Lấy số ngẫu nhiên từ 1 đến 5

                MessageBox.Show("Dang nhap thanh cong!");
                // Đăng nhập thành công, mở form UserForm và đóng LoginForm

                User userForm = new User(user.AccountId, result); // Lấy ID tài khoản để dễ dàng truy xuất sau này
                userForm.Show();  // Mở form người dùng
                this.Hide();  // Ẩn form đăng nhập (LoginForm)

                // Tạo booking mới để lưu trữ thông tin người dùng

                

                var customer = _context.Customers.FirstOrDefault(c => c.AccountId == user.AccountId);
                // Lưu thông tin đăng nhập vào bảng LoginHistory
                var newBooking = new Booking
                {
                    CustomerId = customer.CustomerId,
                    //ComputerId = selectedComputer.ComputerId,
                    ComputerId = result,
                    StartTime = DateTime.Now
                };
                _context.Bookings.Add(newBooking);
                _context.SaveChanges();

            } else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
