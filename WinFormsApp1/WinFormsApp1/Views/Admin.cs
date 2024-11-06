using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Infrastructure;
using Button = System.Windows.Forms.Button;

namespace WinFormsApp1.Views
{
    public partial class Admin : Form
    {

        private readonly GcsmanagerContext _context;
        private System.Windows.Forms.Timer timerUpdate; // Chỉ định rõ Timer từ System.Windows.Forms
        private Computer? selectedComputer; // Biến lưu trữ máy tính được chọn
        private DateTime startTime; // Thời gian bắt đầu
        private const double PricePerHour = 10000; // Số tiền mỗi giờ

        private BindingSource bindingSource = new BindingSource();
        private BindingSource customerBindingSource = new BindingSource();
        private BindingSource bookingBindingSource = new BindingSource();
        private BindingSource accountBindingSource = new BindingSource();
        private BindingSource categoryBindingSource1 = new BindingSource();


        public Admin()
        {
            InitializeComponent();
            _context = new GcsmanagerContext();
            LoadData();
            BindControls();

            // Cấu hình Timer
            timerUpdate = new System.Windows.Forms.Timer(); // Chỉ định rõ
            timerUpdate.Interval = 1000; // Cập nhật mỗi giây
            timerUpdate.Tick += TimerUpdate_Tick; // Đăng ký sự kiện
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateRemainingTime(); // Gọi phương thức cập nhật thời gian
        }

        private void LoadData()
        {
            // Bookings
            var booking = _context.Bookings.ToList();
            dgvBooking.DataSource = booking;

            // Payments
            var payment = _context.Payments.ToList();
            dgvPayment.DataSource = payment;

            // Customer
            var customer = _context.Customers.Include(c => c.Account).ToList();
            customerBindingSource.DataSource = customer;

            LoadComputers();

            // Account
            var account = _context.Accounts.ToList();
            accountBindingSource.DataSource = account;

            // Category
            var category = _context.Categories.ToList();
            categoryBindingSource1.DataSource = category;

            // Product
            var product = _context.Products.Include(p => p.Category).ToList();
            productBindingSource.DataSource = product;
            LoadCategoryIDToComboBox();


            _context.SaveChanges();
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

                    // Đặt lại trạng thái máy tính
                    computer.Status = "Đang mở"; // Cập nhật trạng thái thành "Available"
                    _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    txtStatus.Text = computer.Status;

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

                    // Cập nhật màu sắc của nút
                    btn.BackColor = Color.LightGreen; // Đặt lại màu thành xanh nếu có booking
                };

                flpComputers.Controls.Add(btn);
            }
        }

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
                    double moneyPerSecond = PricePerHour / 3600;
                    double totalMoney = Math.Floor(durationPlayed.TotalSeconds * moneyPerSecond);
                    txtTongTien.Text = totalMoney.ToString();

                    // Cập nhật thời gian còn lại
                    TimeSpan updatedRemainingTime = remainingTime - durationPlayed;
                    if (updatedRemainingTime.TotalSeconds > 0)
                    {
                        txtConLai.Text = $"{(int)updatedRemainingTime.TotalHours}:{updatedRemainingTime.Minutes}:{updatedRemainingTime.Seconds}";
                    }
                    else
                    {
                        // Khi hết thời gian, cập nhật trạng thái và dừng timer
                        txtStatus.Text = "Đang tắt";
                        txtConLai.Text = "Đã hết thời gian";
                        timerUpdate.Stop();

                        // Cập nhật trạng thái máy tính và màu sắc nút
                        selectedComputer.Status = "Đang tắt";
                        _context.SaveChanges();

                        // Tìm và đổi màu nút tương ứng với máy tính
                        foreach (Control control in flpComputers.Controls)
                        {
                            if (control is Button button && button.Tag is Computer computer && computer.ComputerId == selectedComputer.ComputerId)
                            {
                                button.BackColor = Color.LightCoral; // Đổi màu nút sang xám khi máy tính "Đang tắt"
                                break;
                            }
                        }
                    }
                }
            }
        }


        private void BindControls()
        {
            // Xóa binding cho các control trong Account Tab
            txtAccountUserName.DataBindings.Clear();
            txtAccountPasswordHash.DataBindings.Clear();
            txtAccountRole.DataBindings.Clear();
            txtAccountActive.DataBindings.Clear();
            txtAccountCreateDate.DataBindings.Clear();
            txtAccountId.DataBindings.Clear();

            // Xóa binding cho các control trong Category Tab
            txtCategoryId.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            txtCategoryDes.DataBindings.Clear();

            // Xóa binding cho các control trong Product Tab
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtProductDes.DataBindings.Clear();
            txtProductPrice.DataBindings.Clear();
            txtProductStockQuantity.DataBindings.Clear();
            cbbProductCategory.DataBindings.Clear();

            // Xóa binding cho các control trong Customer Tab
            txtCustomerID.DataBindings.Clear();
            txtCusFullName.DataBindings.Clear();
            txtCusPhone.DataBindings.Clear();
            txtCusEmail.DataBindings.Clear();
            txtCusBalance.DataBindings.Clear();
            txtCusRegisterDate.DataBindings.Clear();
            txtCusIsActive.DataBindings.Clear();
            txtAccountName.DataBindings.Clear();

            // Account Tab
            txtAccountUserName.DataBindings.Add("Text", accountBindingSource, "Username");
            txtAccountPasswordHash.DataBindings.Add("Text", accountBindingSource, "PasswordHash");
            txtAccountRole.DataBindings.Add("Text", accountBindingSource, "Role");
            txtAccountActive.DataBindings.Add("Text", accountBindingSource, "IsActive");
            txtAccountCreateDate.DataBindings.Add("Text", accountBindingSource, "CreateDate");
            txtAccountId.DataBindings.Add("Text", accountBindingSource, "AccountId");

            // Category Tab
            txtCategoryId.DataBindings.Add("Text", categoryBindingSource1, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", categoryBindingSource1, "CategoryName");
            txtCategoryDes.DataBindings.Add("Text", categoryBindingSource1, "Description");
            //cbbCategoryProduct.DataBindings.Add("Text", categoryBindingSource1, "ProductID");

            // Product Tab
            txtProductID.DataBindings.Add("Text", productBindingSource, "ProductID");
            txtProductName.DataBindings.Add("Text", productBindingSource, "ProductName");
            txtProductDes.DataBindings.Add("Text", productBindingSource, "Description");
            txtProductPrice.DataBindings.Add("Text", productBindingSource, "Price");
            txtProductStockQuantity.DataBindings.Add("Text", productBindingSource, "StockQuantity");
            cbbProductCategory.DataBindings.Add("Text", productBindingSource, "CategoryName");

            // Customer Tab
            txtCustomerID.DataBindings.Add("Text", customerBindingSource, "CustomerID");
            txtCusFullName.DataBindings.Add("Text", customerBindingSource, "FullName");
            txtCusPhone.DataBindings.Add("Text", customerBindingSource, "Phone");
            txtCusEmail.DataBindings.Add("Text", customerBindingSource, "Email");
            txtCusBalance.DataBindings.Add("Text", customerBindingSource, "Balance");
            txtCusRegisterDate.DataBindings.Add("Text", customerBindingSource, "RegisterDate");
            txtCusIsActive.DataBindings.Add("Text", customerBindingSource, "IsActive");
            txtAccountName.DataBindings.Add("Text", customerBindingSource, "AccountName");
        }

        private void CreateBooking(Booking bookings)
        {
            Booking newBooking = new Booking
            {
                CustomerId = 0,
                ComputerId = 0,
                StartTime = null,
                EndTime = null,
                TotalAmount = 0
            };
        }

        private void LoadCategoryIDToComboBox()
        {
            // Gán ID vào combobox
            var categories = _context.Categories.ToList();

            // Xóa các mục hiện có trong ComboBox
            cbbProductCategory.Items.Clear();

            foreach (var category in categories)
            {
                cbbProductCategory.Items.Add(new { Value = category.CategoryId, Text = category.CategoryName });
            }
            cbbProductCategory.DisplayMember = "Text";
            cbbProductCategory.ValueMember = "Value";
        }
        // Account tab
        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            if (!txtAccountUserName.ReadOnly && !txtAccountPasswordHash.ReadOnly && !txtAccountRole.ReadOnly && !txtAccountActive.ReadOnly)
            {
                var account = _context.Accounts.FirstOrDefault(a => a.AccountId.ToString() == txtAccountId.Text);

                if (account != null)
                {
                    bool isExist = _context.Accounts.Any(p => p.Username == txtAccountUserName.Text);
                    if (!isExist)
                    {
                        account.Username = txtAccountUserName.Text;
                        account.PasswordHash = txtAccountPasswordHash.Text;
                        account.Role = txtAccountRole.Text;
                        account.CreateDate = DateTime.Now;

                        // Active làm chưa được

                        _context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Chỉnh sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đã tồn tại!");
                    }
                }
                else
                {
                    MessageBox.Show("Bảng rỗng!");
                }
            }

            txtAccountUserName.ReadOnly = false;
            txtAccountPasswordHash.ReadOnly = false;
            txtAccountRole.ReadOnly = false;
            txtAccountActive.ReadOnly = false;

        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {

            var account = _context.Accounts.FirstOrDefault(a => a.AccountId.ToString() == txtAccountId.Text);

            if (account != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Accounts.Remove(account);
                    var maxId = _context.Products.Any() ? _context.Accounts.Max(p => p.AccountId) : 0;

                    // Reset lại IDENTITY về ID lỡn nhất còn lại sau khi xóa
                    _context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('Account', RESEED, {maxId})");
                    _context.SaveChanges();

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bảng rỗng!");
            }
        }
        // Category tab
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            // Clear data bindings temporarily
            txtCategoryName.DataBindings.Clear();
            txtCategoryDes.DataBindings.Clear();

            cbbProductCategory.DataBindings.Clear();

            if (txtCategoryName.ReadOnly == false && txtCategoryDes.ReadOnly == false)
            {

                bool isExist = _context.Categories.Any(p => p.CategoryName == txtCategoryName.Text);
                if (!isExist)
                {
                    // Create new Category object
                    var newCategory = new Category
                    {
                        CategoryName = txtCategoryName.Text,
                        Description = txtCategoryDes.Text
                    };

                    // Add the new category to the context
                    _context.Categories.Add(newCategory);

                    // Save changes to the database
                    try
                    {
                        _context.SaveChanges();
                        MessageBox.Show("Tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload data to refresh displayed categories
                        LoadData();
                        BindControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while creating category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đã tồn tại!");
                }
            }

            txtCategoryName.ReadOnly = false;
            txtCategoryDes.ReadOnly = false;
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId.ToString() == txtCategoryId.Text);

            if (category != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                    var maxId = _context.Categories.Any() ? _context.Categories.Max(p => p.CategoryId) : 0;

                    // Reset lại IDENTITY về ID lỡn nhất còn lại sau khi xóa
                    _context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('Categories', RESEED, {maxId})");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bảng rỗng!");
            }
        }

        private void btnCategoryEdit_Click(object sender, EventArgs e)
        {

            if (txtCategoryName.ReadOnly == false && txtCategoryDes.ReadOnly == false)
            {
                var category = _context.Categories.FirstOrDefault(c => c.CategoryId.ToString() == txtCategoryId.Text);

                if (category != null)
                {
                    bool isExist = _context.Categories.Any(c => c.CategoryName == txtCategoryName.Text && c.Description == txtCategoryDes.Text);
                    if (!isExist)
                    {
                        category.CategoryName = txtCategoryName.Text;
                        category.Description = txtCategoryDes.Text;
                        //category.Products = 
                        _context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Chỉnh sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thôn tin đã tồn tại!");
                    }
                }
                else
                {
                    MessageBox.Show("Bảng rỗng!");
                }
            }

            txtCategoryName.ReadOnly = false;
            txtCategoryDes.ReadOnly = false;
        }

        // Product tab
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            // Clear data bindings temporarily
            txtProductName.DataBindings.Clear();
            txtProductDes.DataBindings.Clear();
            txtProductPrice.DataBindings.Clear();
            txtProductStockQuantity.DataBindings.Clear();
            cbbProductCategory.DataBindings.Clear();

            if (txtProductName.ReadOnly == false && txtProductDes.ReadOnly == false && txtProductPrice.ReadOnly == false && txtProductStockQuantity.ReadOnly == false)
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var selectedItem = cbbProductCategory.SelectedItem;

                    if (selectedItem != null)
                    {
                        // Sử dụng dynamic để lấy cả hai thuộc tính
                        var item = (dynamic)selectedItem;
                        int value = item.Value;
                        string text = item.Text;


                        var isExist = _context.Products.Any(p => p.ProductName == txtProductName.Text && p.CategoryId == value);

                        if (!isExist)
                        {
                            // Create new Category object
                            var newProduct = new Product
                            {
                                ProductName = txtProductName.Text,
                                Description = txtProductDes.Text,
                                Price = decimal.Parse(txtProductPrice.Text),
                                StockQuantity = int.Parse(txtProductStockQuantity.Text),
                                CategoryId = value
                            };

                            // Add the new category to the context
                            _context.Products.Add(newProduct);

                            // Save changes to the database
                            try
                            {
                                MessageBox.Show("Tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                _context.SaveChanges();
                                LoadData();
                                BindControls();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error while creating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại!");
                        }
                    }
                }
            }

            txtProductName.ReadOnly = false;
            txtProductDes.ReadOnly = false;
            txtProductPrice.ReadOnly = false;
            txtProductStockQuantity.ReadOnly = false;
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (!txtProductName.ReadOnly && !txtProductDes.ReadOnly && !txtProductPrice.ReadOnly && !txtProductStockQuantity.ReadOnly)
            {
                var selectedItem = cbbProductCategory.SelectedItem;

                if (selectedItem != null)
                {
                    // Sử dụng dynamic để lấy cả hai thuộc tính
                    var item = (dynamic)selectedItem;
                    int categoryId = item.Value;  // Lấy ID của danh mục

                    // Lấy sản phẩm theo ID
                    var product = _context.Products.FirstOrDefault(p => p.ProductId.ToString() == txtProductID.Text);
                    if (product != null)
                    {
                        // Kiểm tra tồn tại sản phẩm với cùng tên và CategoryId
                        bool isExist = _context.Products.Any(p => p.ProductName == txtProductName.Text && p.CategoryId == categoryId);
                        if (!isExist)
                        {
                            // Chuyển đổi giá trị từ textbox với xử lý lỗi
                            if (decimal.TryParse(txtProductPrice.Text, out decimal price) &&
                                int.TryParse(txtProductStockQuantity.Text, out int stockQuantity))
                            {
                                product.ProductName = txtProductName.Text;
                                product.Description = txtProductDes.Text;
                                product.Price = price;
                                product.StockQuantity = stockQuantity;
                                product.CategoryId = categoryId;

                                _context.SaveChanges();
                                LoadData();
                                MessageBox.Show("Chỉnh sửa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Giá và số lượng phải là số hợp lệ!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thông tin đã tồn tại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn phân loại!");
                }
            }

            txtProductName.ReadOnly = false;
            txtProductDes.ReadOnly = false;
            txtProductPrice.ReadOnly = false;
            txtProductStockQuantity.ReadOnly = false;
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            txtProductName.ReadOnly = false;
            txtProductDes.ReadOnly = false;
            txtProductPrice.ReadOnly = false;
            txtProductStockQuantity.ReadOnly = false;

            var product = _context.Products.FirstOrDefault(p => p.ProductId.ToString() == txtProductID.Text);

            if (product != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    var maxId = _context.Products.Any() ? _context.Products.Max(p => p.ProductId) : 0;

                    // Reset lại IDENTITY về ID lỡn nhất còn lại sau khi xóa
                    _context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('Product', RESEED, {maxId})");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bảng rỗng!");
            }
        }
        // Customer tab
        private void btnCusEdit_Click(object sender, EventArgs e)
        {
            if (!txtCusFullName.ReadOnly && !txtCusPhone.ReadOnly && !txtCusEmail.ReadOnly && !txtCusBalance.ReadOnly && !txtCusRegisterDate.ReadOnly && !txtCusIsActive.ReadOnly)
            {
                var customer = _context.Customers.FirstOrDefault(a => a.CustomerId.ToString() == txtCustomerID.Text);

                if (customer != null)
                {
                    customer.FullName = txtCusFullName.Text;
                    customer.Phone = txtCusPhone.Text;
                    customer.Email = txtCusEmail.Text;
                    customer.Balance = decimal.Parse(txtCusBalance.Text);
                    customer.RegisterDate = DateTime.Now;
                    customer.Email = txtCusEmail.Text;
                    // Active chưa làm được
                    _context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Chỉnh sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Bảng rỗng!");
                }
            }

            txtCusFullName.ReadOnly = false;
            txtCusPhone.ReadOnly = false;
            txtCusEmail.ReadOnly = false;
            txtCusBalance.ReadOnly = false;
            txtCusRegisterDate.ReadOnly = false;
            txtCusIsActive.ReadOnly = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (selectedComputer != null)
            {
                // Cập nhật trạng thái của máy tính trong cơ sở dữ liệu
                var computerToUpdate = _context.Computers.FirstOrDefault(c => c.ComputerId == selectedComputer.ComputerId);
                if (computerToUpdate != null)
                {
                    computerToUpdate.Status = "Đang tắt"; // Hoặc trạng thái phù hợp khác
                    _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    // Cập nhật màu sắc của nút tương ứng với máy tính
                    foreach (Control control in flpComputers.Controls)
                    {
                        if (control is Button button && button.Tag is Computer computer && computer.ComputerId == selectedComputer.ComputerId)
                        {
                            button.BackColor = Color.LightCoral;
                            break;
                        }
                    }

                    txtStatus.Text = computerToUpdate.Status;

                    // Dừng timer nếu đang chạy
                    timerUpdate.Stop();
                    selectedComputer = null;
                    txtConLai.Text = "N/A";
                    txtDaChoi.Text = "0:0:0";
                    txtTongTien.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Không có máy tính nào được chọn.");
            }
        }


    }
}
