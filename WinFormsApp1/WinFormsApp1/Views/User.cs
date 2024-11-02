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
            _context = new GcsmanagerContext(); // Khởi tạo DbContext
            _cart = new List<BookingProduct>(); // Khởi tạo danh sách giỏ hàng tạm
            LoadUserData(); // Tải dữ liệu khi form được mở


        }
        private void User_Load_1(object sender, EventArgs e)
        {
            button1.Click += btn_Click;
            button2.Click += btn_Click;
            button3.Click += btn_Click;
            button4.Click += btn_Click;
            button5.Click += btn_Click;
            button6.Click += btn_Click;
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
                // Nếu có, chỉ cập nhật số lượng và tổng giá
                existingProduct.Quantity += quantity;
                existingProduct.TotalPrice += product.Price * quantity;
            }
            else
            {
                // Nếu chưa có, thêm mới vào giỏ hàng
                var bookingProduct = new BookingProduct
                {
                    ProductId = product.ProductId,
                    Quantity = quantity,
                    TotalPrice = product.Price * quantity,
                    BookingId = 0 // Hoặc gán giá trị mặc định khác nếu cần
                };
                _cart.Add(bookingProduct);
            }

            MessageBox.Show($"Đã thêm sản phẩm '{product.ProductName}' với số lượng {quantity} vào giỏ hàng!");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton == null) return;

            Product? productToOrder = null;

            switch (clickedButton.Name)
            {
                case "button1":
                    productToOrder = _context.Products.FirstOrDefault(p => p.ProductName == "Pepsi");
                    break;
                case "button2":
                    productToOrder = _context.Products.FirstOrDefault(p => p.ProductName == "Fanta");
                    break;
                case "button3":
                    productToOrder = _context.Products.FirstOrDefault(p => p.ProductName == "Sting");
                    break;
                case "button4":
                    productToOrder = _context.Products.FirstOrDefault(p => p.ProductName == "Pepsi");
                    break;
                case "button5":
                    productToOrder = _context.Products.FirstOrDefault(p => p.ProductName == "Pepsi");
                    break;
                case "button6":
                    productToOrder = _context.Products.FirstOrDefault(p => p.ProductName == "Pepsi");
                    break;
            }

            if (productToOrder != null)
            {
                // Tìm NumericUpDown với Tag là ProductId
                var numericUpDown = this.Controls
                .OfType<TabControl>() // Lấy tất cả các TabControl trong Form
                .SelectMany(tc => tc.TabPages.Cast<TabPage>()) // Duyệt qua tất cả các TabPage
                .SelectMany(tp => tp.Controls.OfType<Panel>()) // Duyệt qua tất cả các Panel trong từng TabPage
                .SelectMany(p => p.Controls.OfType<NumericUpDown>()) // Duyệt qua tất cả các NumericUpDown trong từng Panel
                .FirstOrDefault(n => n.Tag is int tagValue && tagValue == productToOrder.ProductId);

                // Kiểm tra và lấy giá trị
                int quantity = numericUpDown != null ? (int)numericUpDown.Value : 1;


                AddBookingProduct(productToOrder, quantity); // Thêm vào giỏ hàng tạm
            }
        }


        private void LoadUserData()
        {
            try
            {
                var productData = _context.Products.ToList();

                // Tạo danh sách PictureBox và các Label tương ứng
                var pictureBoxesTab1 = new List<PictureBox>
                {
                    guna2PictureBox1, guna2PictureBox2, guna2PictureBox3,
                };
                var pictureBoxesTab2 = new List<PictureBox>
                {
                    guna2PictureBox4, guna2PictureBox5, guna2PictureBox6
                };
                var productNamesTab1 = new List<Label>
                {
                    lblProductName1, lblProductName2, lblProductName3,
                };
                var productNamesTab2 = new List<Label>
                {
                    lblProductName4, lblProductName5, lblProductName6
                };
                var productPricesTab1 = new List<Label>
                {
                    lblProductPrice1, lblProductPrice2, lblProductPrice3,
                };
                var productPricesTab2 = new List<Label>
                {
                    lblProductPrice4, lblProductPrice5, lblProductPrice6
                };
                var productDescriptionsTab1 = new List<Label>
                {
                    lblProductDes1, lblProductDes2, lblProductDes3,
                };
                var productDescriptionsTab2 = new List<Label>
                {
                    lblProductDes4, lblProductDes5, lblProductDes6
                };
                var numericUpDownsTab1 = new List<NumericUpDown>
                {
                    numericUpDown1, numericUpDown2, numericUpDown3
                };
                var numericUpDownsTab2 = new List<NumericUpDown>
                {
                    numericUpDown4, numericUpDown5, numericUpDown6
                };

                // Biến đếm riêng cho từng Tab
                int countTab1 = 0;
                int countTab2 = 0;

                foreach (var product in productData)
                {
                    if (!string.IsNullOrEmpty(product.Image))
                    {
                        // Tạo PictureBox tạm để tải ảnh từ URL
                        PictureBox tempPictureBox = new PictureBox();
                        tempPictureBox.Load(product.Image);

                        if (product.CategoryId == 1 && countTab1 < pictureBoxesTab1.Count)
                        {
                            // Gán ảnh và thông tin vào các PictureBox và Label tương ứng
                            pictureBoxesTab1[countTab1].Image = tempPictureBox.Image;
                            //pictureBoxesTab1[countTab1].Tag = product.ProductId;
                            productNamesTab1[countTab1].Text = product.ProductName;
                            productPricesTab1[countTab1].Text = product.Price.ToString();
                            productDescriptionsTab1[countTab1].Text = product.Description;

                            MessageBox.Show(numericUpDownsTab1[countTab1].Tag?.ToString());

                            countTab1++;
                        }
                        else if (product.CategoryId == 2 && countTab2 < pictureBoxesTab2.Count)
                        {
                            // Hiển thị ở Tab 2
                            pictureBoxesTab2[countTab2].Image = tempPictureBox.Image;
                            //pictureBoxesTab1[countTab2].Tag = product.ProductId;
                            productNamesTab2[countTab2].Text = product.ProductName;
                            productPricesTab2[countTab2].Text = product.Price.ToString();
                            productDescriptionsTab2[countTab2].Text = product.Description;

                            numericUpDownsTab2[countTab2].Tag = product.ProductId;

                            countTab2++;
                        }

                        // Dừng vòng lặp nếu đã gán đủ dữ liệu cho tất cả các PictureBox ở cả hai Tab
                        if (countTab1 >= pictureBoxesTab1.Count && countTab2 >= pictureBoxesTab2.Count)
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
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
