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
    public partial class User : Form
    {
        private GcsmanagerContext _context;
        public User()
        {
            InitializeComponent();
            InitializeComponent();
            _context = new GcsmanagerContext(); // Khởi tạo DbContext
            LoadAccountData(); // Tải dữ liệu khi form được mở
        }

        private void LoadAccountData()
        {
            try
            {
                // Lấy dữ liệu từ bảng Account
                var accountData = _context.Customers.ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
