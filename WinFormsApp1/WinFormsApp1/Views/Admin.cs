using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Admin : Form
    {
        private readonly GcsmanagerContext _context;
        private System.Windows.Forms.Timer timerUpdate; // Chỉ định rõ Timer từ System.Windows.Forms
        private Computer selectedComputer; // Biến lưu trữ máy tính được chọn
        private DateTime startTime; // Thời gian bắt đầu
        private const double PricePerHour = 10000; // Số tiền mỗi giờ

        public Admin()
        {
            InitializeComponent();
            _context = new GcsmanagerContext();
            loadDataBooking();
            LoadComputers();

            // Cấu hình Timer
            timerUpdate = new System.Windows.Forms.Timer(); // Chỉ định rõ
            timerUpdate.Interval = 1000; // Cập nhật mỗi giây
            timerUpdate.Tick += TimerUpdate_Tick; // Đăng ký sự kiện
        }

        // Cập nhật thời gian mỗi giây
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateRemainingTime(); // Gọi phương thức cập nhật thời gian
        }

        // Tải dữ liệu booking
        public void loadDataBooking()
        {
            var dataBooking = _context.Bookings.ToList();
            dgvBooking.DataSource = dataBooking;
        }

        // Tải danh sách máy tính
        private void LoadComputers()
        {
            // Xóa các control cũ nếu có
            flpComputers.Controls.Clear();

            // Truy vấn dữ liệu từ bảng Computers
            var computers = _context.Computers.ToList();

            foreach (var computer in computers)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 80;
                btn.Text = computer.ComputerName;
                btn.BackColor = computer.Status == "Available" ? Color.LightGreen : Color.LightCoral;

                // Gán tag cho nút để lưu trữ thông tin về máy tính
                btn.Tag = computer;

                // Đăng ký sự kiện click cho nút
                btn.Click += (sender, e) =>
                {
                    // Lưu thông tin máy tính được chọn
                    selectedComputer = computer;

                    // Lấy thông tin Booking cho máy tính được nhấn
                    var booking = _context.Bookings.FirstOrDefault(b => b.ComputerId == computer.ComputerId);
                    if (booking != null)
                    {
                        bindingComputer(computer, booking);
                        startTime = DateTime.Now; // Lưu thời gian bắt đầu
                        timerUpdate.Start(); // Bắt đầu Timer khi có booking
                    }
                    else
                    {
                        txtConLai.Text = "Không có booking nào cho máy tính này.";
                        txtDaChoi.Text = "0:0:0"; // Đặt lại thời gian đã chơi nếu không có booking
                        txtTongTien.Text = "0"; // Đặt lại tổng tiền
                    }
                };

                flpComputers.Controls.Add(btn);
            }
        }

        // Ràng buộc dữ liệu
        private void bindingComputer(Computer computer, Booking booking)
        {
            if (booking.StartTime.HasValue)
            {
                // Lấy thông tin khách hàng
                var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == booking.CustomerId);
                if (customer != null)
                {
                    // Chuyển đổi Balance sang double
                    double customerBalance = customer.Balance.HasValue ? (double)customer.Balance.Value : 0;

                    // Tính số giờ còn lại dựa vào số tiền còn lại
                    double remainingHours = customerBalance / PricePerHour;

                    // Chuyển đổi số giờ còn lại thành TimeSpan
                    TimeSpan remainingTime = TimeSpan.FromHours(remainingHours);

                    // Hiển thị thời gian còn lại theo định dạng h:m:s
                    txtConLai.Text = $"{(int)remainingTime.TotalHours}:{remainingTime.Minutes}:{remainingTime.Seconds}";
                    txtDaChoi.Text = "0:0:0"; // Khởi tạo thời gian đã chơi
                    txtTongTien.Text = "0"; // Khởi tạo tổng tiền
                }
                else
                {
                    txtConLai.Text = "Khách hàng không tồn tại";
                }
            }
            else
            {
                txtConLai.Text = "N/A"; // Hoặc bất kỳ thông báo nào phù hợp
            }
        }

        // Cập nhật thời gian còn lại và thời gian đã chơi
        private void UpdateRemainingTime()
        {
            if (selectedComputer != null)
            {
                var booking = _context.Bookings.FirstOrDefault(b => b.ComputerId == selectedComputer.ComputerId);
                if (booking != null && booking.StartTime.HasValue)
                {
                    DateTime now = DateTime.Now;

                    // Tính toán thời gian đã chơi
                    TimeSpan durationPlayed = now - startTime;

                    // Tính số giờ còn lại dựa vào số tiền còn lại
                    double customerBalance = (double)(_context.Customers.FirstOrDefault(c => c.CustomerId == booking.CustomerId)?.Balance ?? 0);
                    double remainingHours = customerBalance / PricePerHour;

                    // Chuyển đổi số giờ còn lại thành TimeSpan
                    TimeSpan remainingTime = TimeSpan.FromHours(remainingHours);

                    // Cập nhật thời gian đã chơi
                    txtDaChoi.Text = $"{(int)durationPlayed.TotalHours}:{durationPlayed.Minutes}:{durationPlayed.Seconds}";

                    // Tính tổng tiền dựa theo số giây đã chơi
                    double moneyPerSecond = PricePerHour / 3600; // Tính tiền mỗi giây
                    double totalMoney = Math.Floor(durationPlayed.TotalSeconds * moneyPerSecond); // Tính tổng tiền
                    txtTongTien.Text = totalMoney.ToString(); // Hiển thị tổng tiền

                    // Cập nhật thời gian còn lại
                    TimeSpan updatedRemainingTime = remainingTime - durationPlayed;
                    if (updatedRemainingTime.TotalSeconds > 0)
                    {
                        txtConLai.Text = $"{(int)updatedRemainingTime.TotalHours}:{updatedRemainingTime.Minutes}:{updatedRemainingTime.Seconds}";
                    }
                    else
                    {
                        txtConLai.Text = "Đã hết thời gian";
                        timerUpdate.Stop(); // Dừng timer nếu thời gian đã hết
                    }
                }
            }
        }
    }
}
