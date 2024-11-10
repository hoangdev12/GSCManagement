using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp1.Views
{
    public partial class User : Form
    {
        private GcsmanagerContext _context;
        private List<BookingProduct> _cart; // Danh sách tạm để lưu sản phẩm
        public User()
        {
            InitializeComponent();
            _context = new GcsmanagerContext();
            _cart = new List<BookingProduct>();
            LoadUserData(); // Tải dữ liệu khi mở form
            
        }

        private void User_Load_1(object sender, EventArgs e)
        {
        }

        private void LoadUserData()
        {
            try
            {
                var productData = _context.Products.ToList();

                // Tạo FlowLayoutPanel cho thực phẩm và đồ uống
                FlowLayoutPanel flowFoods = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true, // Cho phép wrap để chuyển sang hàng mới
                    Dock = DockStyle.Fill // Đảm bảo nó lấp đầy không gian có sẵn
                };

                FlowLayoutPanel flowDrinks = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true, // Cho phép wrap để chuyển sang hàng mới
                    Dock = DockStyle.Fill // Đảm bảo nó lấp đầy không gian có sẵn
                };

                FlowLayoutPanel flowServices = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true, // Cho phép wrap để chuyển sang hàng mới
                    Dock = DockStyle.Fill // Đảm bảo nó lấp đầy không gian có sẵn
                };

                dgvCart.AutoGenerateColumns = false; // Đặt AutoGenerateColumns thành false

                // Thêm cột ProductName cho DataGridView
                DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
                productNameColumn.DataPropertyName = "ProductName"; // Tên thuộc tính trong nguồn dữ liệu
                productNameColumn.HeaderText = "Tên Sản Phẩm/Dịch Vụ";
                dgvCart.Columns.Add(productNameColumn);

                // Thêm cột Quantity
                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.DataPropertyName = "Quantity"; // Tên thuộc tính trong nguồn dữ liệu
                quantityColumn.HeaderText = "Số Lượng";
                dgvCart.Columns.Add(quantityColumn);

                // Thêm cột TotalPrice
                DataGridViewTextBoxColumn totalPriceColumn = new DataGridViewTextBoxColumn();
                totalPriceColumn.DataPropertyName = "TotalPrice"; // Tên thuộc tính trong nguồn dữ liệu
                totalPriceColumn.HeaderText = "Tổng Tiền";
                dgvCart.Columns.Add(totalPriceColumn);


                foreach (var product in productData)
                {
                    if (!string.IsNullOrEmpty(product.Image))
                    {
                        // Tạo và cấu hình PictureBox cho hình ảnh sản phẩm
                        PictureBox pictureBox = new PictureBox
                        {
                            Size = new Size(100, 100),
                            ImageLocation = Path.Combine(Application.StartupPath, "Resource", "Img", product.Image),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };

                        // Tạo và cấu hình Label cho tên sản phẩm
                        Label nameLabel = new Label
                        {
                            Text = product.ProductName,
                            AutoSize = true,
                        };

                        // Tạo và cấu hình Label cho giá sản phẩm
                        Label priceLabel = new Label
                        {
                            Text = $"Price: {product.Price}",
                            AutoSize = true,
                        };

                        // Tạo và cấu hình NumericUpDown cho việc chọn số lượng
                        NumericUpDown quantitySelector = new NumericUpDown
                        {
                            Minimum = 1,
                            Maximum = 20,
                            Value = 1,
                            Tag = product.ProductId, // Gán ProductId vào Tag
                        };

                        // Tạo và cấu hình Button cho việc thêm sản phẩm vào giỏ hàng
                        Button addButton = new Button
                        {
                            Size = new Size(120, 50),
                            Text = "Add to Cart",
                            Tag = product.ProductId, // Gán ProductId cho nút
                        };
                        addButton.Click += btn_Click; // Gán sự kiện click

                        // Tạo Panel để chứa tất cả các control sản phẩm
                        Panel productPanel = new Panel
                        {
                            Size = new Size(150, 250),
                            BorderStyle = BorderStyle.FixedSingle,
                        };

                        // Thêm các control vào productPanel
                        productPanel.Controls.Add(pictureBox);
                        productPanel.Controls.Add(nameLabel);
                        productPanel.Controls.Add(priceLabel);
                        productPanel.Controls.Add(quantitySelector);
                        productPanel.Controls.Add(addButton);

                        // Căn chỉnh vị trí của các control
                        pictureBox.Location = new Point(10, 10);
                        nameLabel.Location = new Point(10, 120);
                        priceLabel.Location = new Point(10, 140);
                        quantitySelector.Location = new Point(10, 160);
                        addButton.Location = new Point(10, 190);

                        // Thêm productPanel vào FlowLayoutPanel tương ứng dựa trên CategoryID
                        if (product.CategoryId == 2) // CategoryID = 2 là Food
                        {
                            flowFoods.Controls.Add(productPanel);
                        }
                        else if (product.CategoryId == 1) // CategoryID = 1 là Drink
                        {
                            flowDrinks.Controls.Add(productPanel);
                        }
                        else if (product.CategoryId == 3)
                        {
                            flowServices.Controls.Add(productPanel);
                        }
                    }
                }

                // Đặt FlowLayoutPanel vào TabPage
                tbpFoods.Controls.Add(flowFoods);
                tbpDrinks.Controls.Add(flowDrinks);
                tbpService.Controls.Add(flowServices);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton == null || clickedButton.Tag == null) return;

            int productId = (int)clickedButton.Tag;
            Product? productToOrder = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (productToOrder != null)
            {
                NumericUpDown? quantitySelector = null;

                // Tìm NumericUpDown trong tbpFoods, tbpDrinks, và tbpService
                foreach (TabPage tabPage in new[] { tbpFoods, tbpDrinks, tbpService })
                {
                    foreach (FlowLayoutPanel flowPanel in tabPage.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (Panel panel in flowPanel.Controls.OfType<Panel>())
                        {
                            quantitySelector = panel.Controls.OfType<NumericUpDown>()
                                .FirstOrDefault(n => (int?)n.Tag == productId);
                            if (quantitySelector != null) break;
                        }
                        if (quantitySelector != null) break;
                    }
                    if (quantitySelector != null) break;
                }

                if (quantitySelector == null)
                {
                    MessageBox.Show("Không tìm thấy số lượng cho sản phẩm này.");
                }
                else
                {
                    int quantity = (int)quantitySelector.Value;
                    AddBookingProduct(productToOrder, quantity);
                    LoadCartData();
                }
            }
        }


        private void AddBookingProduct(Product product, int quantity)
        {
            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm phải lớn hơn 0!");
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
            var existingProduct = _cart.FirstOrDefault(bp => bp.ProductId == product.ProductId);

            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
                existingProduct.TotalPrice += product.Price * quantity;
                MessageBox.Show($"Cập nhật sản phẩm: {product.ProductName}, Số lượng mới: {existingProduct.Quantity}");
            }
            else
            {
                var bookingProduct = new BookingProduct
                {
                    ProductId = product.ProductId,
                    Quantity = quantity,
                    TotalPrice = product.Price * quantity,
                    //BookingId = 0
                };
                _cart.Add(bookingProduct);
            
                MessageBox.Show($"Đã thêm sản phẩm '{product.ProductName}' với số lượng {quantity} vào giỏ hàng!");
            }
            // Cập nhật lại tổng tiền trong lblTotalAll
            lblTotalAll.Text = _cart.Sum(bp => bp.TotalPrice).ToString();

        }

        private void btnBuy_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_cart.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng trống, không có sản phẩm nào để lưu!");
                    return;
                }

                // Kiểm tra sự tồn tại của CustomerId và ComputerId
                var existingCustomer = _context.Customers.FirstOrDefault(c => c.CustomerId == 1);
                if (existingCustomer == null)
                {
                    MessageBox.Show("CustomerId không tồn tại. Vui lòng chọn một CustomerId hợp lệ.");
                    return;
                }

                var existingComputer = _context.Computers.FirstOrDefault(c => c.ComputerId == 1);
                if (existingComputer == null)
                {
                    MessageBox.Show("ComputerId không tồn tại. Vui lòng chọn một ComputerId hợp lệ.");
                    return;
                }

                // Tạo một Booking mới và lưu vào cơ sở dữ liệu
                var newBooking = new Booking
                {
                    CustomerId = 1, // Gán giá trị cho CustomerID
                    ComputerId = 1, // Gán giá trị cho ComputerID
                    StartTime = DateTime.Now, // Hoặc giá trị thời gian bắt đầu phù hợp
                    EndTime = DateTime.Now.AddHours(1), // Thay đổi nếu cần
                    TotalAmount = _cart.Sum(bp => bp.TotalPrice) // Tính tổng số tiền
                };

                _context.Bookings.Add(newBooking);
                _context.SaveChanges(); // Lưu Booking để có BookingID

                // Gán BookingID cho từng BookingProduct trong giỏ hàng
                foreach (var bookingProduct in _cart)
                {
                    bookingProduct.BookingId = newBooking.BookingId; // Gán BookingID vừa tạo
                    _context.BookingProducts.Add(bookingProduct);
                }

                _context.SaveChanges(); // Lưu BookingProducts vào cơ sở dữ liệu

                _cart.Clear(); // Xóa giỏ hàng sau khi lưu thành công
                LoadCartData();
                lblTotalAll.Text = "0";

                MessageBox.Show("Đã lưu giỏ hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu giỏ hàng: " + ex.ToString());
            }
        }

        private void LoadCartData()
        {
            var cartData = _cart
        .Select(bp => new
        {
            ProductName = _context.Products.FirstOrDefault(p => p.ProductId == bp.ProductId)?.ProductName ?? "Sản phẩm không xác định",
            bp.Quantity,
            bp.TotalPrice
        })
        .ToList();

            // Liên kết dữ liệu vào DataGridView
            dgvCart.DataSource = cartData;
        }


        private void button4_Click(object sender, EventArgs e)
        {
        }

        
    }
}
