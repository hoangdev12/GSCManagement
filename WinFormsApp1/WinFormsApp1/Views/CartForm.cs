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
    public partial class CartForm : Form
    {
        public CartForm(List<BookingProduct> cart, GcsmanagerContext context)
        {
            InitializeComponent();
            LoadCartItems(cart, context);
        }


        private void LoadCartItems(List<BookingProduct> cart, GcsmanagerContext context)
        {
            foreach (var bookingProduct in cart)
            {
                // Lấy thông tin sản phẩm từ ProductId
                var product = context.Products.FirstOrDefault(p => p.ProductId == bookingProduct.ProductId);
                if (product != null)
                {
                    // Tạo Panel cho từng sản phẩm
                    Panel productPanel = new Panel
                    {
                        Size = new Size(200, 300),
                        BorderStyle = BorderStyle.FixedSingle,
                    };

                    // PictureBox cho ảnh sản phẩm
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(100, 100),
                        ImageLocation = product.Image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top
                    };

                    // Label cho tên sản phẩm
                    Label nameLabel = new Label
                    {
                        Text = product.ProductName,
                        AutoSize = true,
                        Dock = DockStyle.Top,
                    };

                    // Label cho số lượng
                    Label quantityLabel = new Label
                    {
                        Text = $"Số lượng: {bookingProduct.Quantity}",
                        AutoSize = true,
                        Dock = DockStyle.Top,
                    };

                    // Label cho giá sản phẩm
                    Label priceLabel = new Label
                    {
                        Text = $"Giá: {product.Price}",
                        AutoSize = true,
                        Dock = DockStyle.Top,
                    };

                    // Label cho tổng tiền
                    Label totalPriceLabel = new Label
                    {
                        Text = $"Tổng: {bookingProduct.TotalPrice}",
                        AutoSize = true,
                        Dock = DockStyle.Top,
                    };

                    // Thêm các control vào Panel sản phẩm
                    productPanel.Controls.Add(totalPriceLabel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(quantityLabel);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(pictureBox);

                    // Thêm Panel sản phẩm vào FlowLayoutPanel trong CartForm
                    flowLayoutPanelCart.Controls.Add(productPanel);
                }
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
