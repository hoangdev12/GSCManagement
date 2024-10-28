using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Admin : Form
    {
        private GcsmanagerContext _context;

        public Admin()
        {
            InitializeComponent();
            _context = new GcsmanagerContext(); // Khởi tạo DbContext
            LoadAccountData(); // Tải dữ liệu khi form được mở
        }

        private void LoadAccountData()
        {
            try
            {
                // Lấy dữ liệu từ bảng Account
                var accountData = _context.Accounts.ToList();

                // Gán dữ liệu vào DataGridView
                dataAccount.DataSource = accountData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void Viewtest_Click(object sender, EventArgs e)
        {
            LoadAccountData();
        }

        private void Viewtest_Click_1(object sender, EventArgs e)
        {
            LoadAccountData();
        }
    }
}
