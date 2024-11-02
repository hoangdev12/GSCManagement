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
            User_Load_1(this, EventArgs.Empty); // Gọi sự kiện tải trực tiếp

            //button1.Click += btn_Click;
            //button2.Click += btn_Click;
            //button3.Click += btn_Click;
            //button4.Click += btn_Click;
            //button5.Click += btn_Click;
            //button6.Click += btn_Click;
        }

        private void User_Load_1(object sender, EventArgs e)
        {
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
                    BookingId = 0
                };
                _cart.Add(bookingProduct);
            }

            MessageBox.Show($"Đã thêm sản phẩm '{product.ProductName}' với số lượng {quantity} vào giỏ hàng!");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton == null || clickedButton.Tag == null) return;

            int productId = (int)clickedButton.Tag; // Lấy ProductId từ thuộc tính Tag
            Product? productToOrder = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (productToOrder != null)
            {
                NumericUpDown? numericUpDown = null;

                // Tìm NumericUpDown trong tbpFoods
                foreach (FlowLayoutPanel flowPanel in tbpFoods.Controls.OfType<FlowLayoutPanel>())
                {
                    foreach (Panel panel in flowPanel.Controls.OfType<Panel>())
                    {
                        numericUpDown = panel.Controls.OfType<NumericUpDown>()
                            .FirstOrDefault(n => (int)n.Tag == productId);
                        if (numericUpDown != null) break; // Nếu tìm thấy thì thoát khỏi vòng lặp
                    }
                    if (numericUpDown != null) break; // Nếu tìm thấy thì thoát khỏi vòng lặp
                }

                // Nếu không tìm thấy trong tbpFoods, tìm trong tbpDrinks
                if (numericUpDown == null)
                {
                    foreach (FlowLayoutPanel flowPanel in tbpDrinks.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (Panel panel in flowPanel.Controls.OfType<Panel>())
                        {
                            numericUpDown = panel.Controls.OfType<NumericUpDown>()
                                .FirstOrDefault(n => (int)n.Tag == productId);
                            if (numericUpDown != null) break; // Nếu tìm thấy thì thoát khỏi vòng lặp
                        }
                        if (numericUpDown != null) break; // Nếu tìm thấy thì thoát khỏi vòng lặp
                    }
                }

                if (numericUpDown == null)
                {
                    MessageBox.Show("Không tìm thấy NumericUpDown cho sản phẩm này.");
                }
                else
                {
                    int quantity = (int)numericUpDown.Value; // Lấy số lượng
                    AddBookingProduct(productToOrder, quantity); // Thêm vào giỏ hàng
                }
            }
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

                foreach (var product in productData)
                {
                    if (!string.IsNullOrEmpty(product.Image))
                    {
                        // Tạo và cấu hình PictureBox cho hình ảnh sản phẩm
                        PictureBox pictureBox = new PictureBox
                        {
                            Size = new Size(100, 100),
                            ImageLocation = product.Image,
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
                        if (product.CategoryId == 2) // Giả sử CategoryID = 1 là Food
                        {
                            flowFoods.Controls.Add(productPanel);
                        }
                        else if (product.CategoryId == 1) // Giả sử CategoryID = 2 là Drink
                        {
                            flowDrinks.Controls.Add(productPanel);
                        }
                    }
                }

                // Đặt FlowLayoutPanel vào TabPage
                tbpFoods.Controls.Add(flowFoods);
                tbpDrinks.Controls.Add(flowDrinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }






        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnSaveCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cart.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng trống, không có sản phẩm nào để lưu!");
                    return;
                }

                // Tạo một Booking mới và lưu vào cơ sở dữ liệu
                var newBooking = new Booking
                {
                    CustomerId = 8/* Gán giá trị cho CustomerID ở đây */,
                    ComputerId = 8/* Gán giá trị cho ComputerID ở đây */,
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
                MessageBox.Show("Đã lưu giỏ hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu giỏ hàng: " + ex.InnerException?.Message ?? ex.Message);
            }
        }

    }
}
