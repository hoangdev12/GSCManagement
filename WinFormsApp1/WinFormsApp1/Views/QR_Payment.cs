using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RestSharp;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class QR_Payment : Form
    {
        private int bankID = 970432, totalAmount;
        private string bankNumber = "0978798367", ownerName = "NGUYEN HAI SON";

        public QR_Payment(int TongTien)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            totalAmount = TongTien;
        }

        // Chuyển đổi chuỗi Base64 thành hình ảnh
        public Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu Base64 không hợp lệ.");
                return null;
            }
        }

        // Sử dụng HttpClient để tải dữ liệu ngân hàng
        private async Task LoadBankDataAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync("https://api.vietqr.io/v2/banks");
                    var listBankData = JsonConvert.DeserializeObject<Bank>(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu ngân hàng: {ex.Message}");
            }
        }

        // Tải dữ liệu ngân hàng khi form được tải
        private async void QR_Payment_Load(object sender, EventArgs e)
        {
            await LoadBankDataAsync();

            // Gọi API để tạo mã QR

            // Kiểm tra dữ liệu người dùng
            if (totalAmount == null || string.IsNullOrEmpty(ownerName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (totalAmount <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ.");
                return;
            }

            try
            {
                var apiRequest = new Service.ApiRequest
                {
                    //acqId = Convert.ToInt32(cbbBank.SelectedValue.ToString()),
                    //accountNo = txtBankNumer.Text,
                    //accountName = txtOwnerBank.Text,
                    //amount = Convert.ToInt32(txtAmout.Text),
                    acqId = bankID,
                    accountNo = bankNumber,
                    accountName = ownerName,
                    amount = totalAmount,
                    format = "text",
                    template = "compact2"
                };

                var jsonRequest = JsonConvert.SerializeObject(apiRequest);

                // Sử dụng RestSharp để gửi yêu cầu API
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = RestSharp.Method.Post;
                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    var dataResult = JsonConvert.DeserializeObject<Service.ApiResponse>(response.Content);

                    if (dataResult != null)
                    {
                        var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                        pictureBox1.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo mã QR.");
                    }
                }
                else
                {
                    MessageBox.Show($"Lỗi API: {response.StatusDescription}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mã QR: {ex.Message}");
            }
        }
    }
}
