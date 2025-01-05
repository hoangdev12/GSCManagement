using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormsApp1.Models;
using ClosedXML.Excel;


namespace WinFormsApp1.Views
{
    public partial class Report : Form
    {
        private GcsmanagerContext _context = new GcsmanagerContext();

        public Report()
        {
            InitializeComponent();
            InitializeComboBoxes();
            CreateColumnChart(DateTime.Now.Year, DateTime.Now.Month);
        }

        // Khởi tạo ComboBox với các giá trị năm và tháng
        private void InitializeComboBoxes()
        {
            // Thêm các năm vào comboBoxYear (ví dụ: từ 2000 đến hiện tại)
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i);
            }
            comboBoxYear.SelectedItem = DateTime.Now.Year;

            // Thêm các tháng vào comboBoxMonth (1 - 12)
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }
            comboBoxMonth.SelectedItem = DateTime.Now.Month;

            // Đăng ký sự kiện thay đổi năm
            comboBoxYear.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            // Đăng ký sự kiện thay đổi tháng
            comboBoxMonth.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        // Hàm tạo biểu đồ cột theo tháng và năm
        private void CreateColumnChart(int year, int month)
        {
            // Tạo đối tượng Chart
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(chart);

            // Thêm ChartArea
            ChartArea chartArea = new ChartArea("RevenueArea");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Doanh thu (VND)";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Days; // Hiển thị từng ngày
            chartArea.AxisX.LabelStyle.Format = "dd/MM";              // Định dạng ngày trên trục X
            chartArea.AxisX.Interval = 1;                            // Hiển thị nhãn mỗi ngày
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;   // Lưới trục X
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;   // Lưới trục Y
            chart.ChartAreas.Add(chartArea);

            // Thêm Series
            Series revenueSeries = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column, // Loại biểu đồ cột
                BorderWidth = 2,                   // Độ dày của đường biên cột
                Color = Color.Blue,                // Màu của cột
                IsValueShownAsLabel = true         // Hiển thị giá trị trên cột
            };
            chart.Series.Add(revenueSeries);

            // Lấy danh sách booking từ cơ sở dữ liệu
            var booking = _context.Bookings.ToList();

            // Lấy tất cả các ngày trong tháng được chọn
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng

            // Tạo danh sách các ngày trong tháng
            List<DateTime> allDatesInMonth = new List<DateTime>();
            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                allDatesInMonth.Add(currentDate);
            }

            // Duyệt qua các ngày trong tháng và tính doanh thu cho từng ngày
            var dailyRevenue = allDatesInMonth
                .Select(date => new
                {
                    Date = date,
                    Revenue = booking
                                .Where(b => b.StartTime.HasValue && b.StartTime.Value.Date == date.Date)
                                .Sum(b => b.TotalAmount) // Tính tổng doanh thu cho ngày đó
                })
                .OrderBy(x => x.Date);  // Sắp xếp theo ngày

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in dailyRevenue)
            {
                revenueSeries.Points.AddXY(item.Date, item.Revenue);
            }

            // Thêm tiêu đề cho biểu đồ
            Title title = new Title("Biểu đồ doanh thu theo ngày", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
            chart.Titles.Add(title);
        }

        // Sự kiện khi người dùng thay đổi năm hoặc tháng
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox nào đã thay đổi
            if (comboBoxYear.SelectedItem != null && comboBoxMonth.SelectedItem != null)
            {
                // Lấy giá trị năm và tháng đã chọn
                int selectedYear = (int)comboBoxYear.SelectedItem;
                int selectedMonth = (int)comboBoxMonth.SelectedItem;

                // Tìm biểu đồ đã có trên form
                var existingChart = this.Controls.OfType<Chart>().FirstOrDefault();

                if (existingChart != null)
                {
                    // Xóa biểu đồ cũ (Chart)
                    this.Controls.Remove(existingChart);
                    existingChart.Dispose();
                }

                // Tạo lại biểu đồ mới với năm và tháng mới
                CreateColumnChart(selectedYear, selectedMonth);
            }
        }

        private void SaveChartDataToExcel_Click_1(object sender, EventArgs e)
        {
            // Lấy biểu đồ đã có trong form (nếu có)
            var existingChart = this.Controls.OfType<Chart>().FirstOrDefault();

            if (existingChart == null)
            {
                MessageBox.Show("Không có biểu đồ để lưu dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*",
                Title = "Save Excel File",
                FileName = "chart_data.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Chart Data");

                    // Lưu tiêu đề
                    worksheet.Cell(1, 1).Value = "Ngày";
                    worksheet.Cell(1, 2).Value = "Doanh thu (VND)";

                    // Duyệt qua các điểm dữ liệu trong biểu đồ cột
                    int rowIndex = 2;
                    foreach (var point in existingChart.Series[0].Points)
                    {
                        // Lấy ngày và doanh thu từ điểm dữ liệu
                        var date = point.XValue;  // Ngày
                        var revenue = point.YValues[0];  // Doanh thu

                        // Lưu vào Excel
                        worksheet.Cell(rowIndex, 1).Value = DateTime.FromOADate(date).ToString("dd/MM/yyyy");
                        worksheet.Cell(rowIndex, 2).Value = revenue;

                        rowIndex++;
                    }

                    // Lưu workbook vào file
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Dữ liệu đã được lưu vào Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu vào Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
