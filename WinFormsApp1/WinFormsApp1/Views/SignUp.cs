using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Oauth2.v2.Data;
using Google.Apis.Services;
using System;
using System.Diagnostics;
using System.Threading;
using Google.Apis.Util.Store;
using Microsoft.Web.WebView2.Core;

namespace WinFormsApp1.Views
{
    public partial class SignUp : Form
    {
        private string clientId = "579771809210-7hgf5bnv3126pj7v685ti3ilk492ule8.apps.googleusercontent.com";
        private string clientSecret = "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";
       

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
          
        }

        private async void LoginWithGoogle()
        {
            try
            {
                var clientSecrets = new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                };

                // Sử dụng một `FileDataStore` không lưu lại dữ liệu qua các lần đăng nhập
                var dataStore = new FileDataStore("TempStore", fullPath: true);
                dataStore.ClearAsync(); // Xóa toàn bộ dữ liệu đã lưu trước đó

                // Tiến hành xác thực lại
                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    new[] { Oauth2Service.Scope.UserinfoEmail, Oauth2Service.Scope.UserinfoProfile },
                    "user",
                    CancellationToken.None,
                    dataStore);

                var service = new Oauth2Service(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential
                });

                Userinfo userInfo = service.Userinfo.Get().Execute();

                MessageBox.Show($"Đăng nhập thành công với Google!\nTên: {userInfo.Name}\nEmail: {userInfo.Email}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập Google thất bại: " + ex.Message);
            }
        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidPassword(string password)
        {
            // Biểu thức chính quy kiểm tra mật khẩu phải có ít nhất một chữ cái, một số và một ký tự đặc biệt
            var hasLetter = new Regex(@"[a-zA-Z]+");       // Kiểm tra có chữ cái
            var hasDigit = new Regex(@"\d+");              // Kiểm tra có số
            var hasSpecialChar = new Regex(@"[!@#$%^&*(),.?""{}|<>[\]~`]");            // Kiểm tra có ký tự đặc biệt

            return hasLetter.IsMatch(password) && hasDigit.IsMatch(password) && hasSpecialChar.IsMatch(password);
        }

        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Kiểm tra các trường có được điền đầy đủ không
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra xem mật khẩu có khớp không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng thử lại.");
                return;
            }

            // Kiểm tra độ phức tạp của mật khẩu
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải bao gồm ít nhất một chữ cái, một số và một ký tự đặc biệt.");
                return;
            }

            // Mã hóa mật khẩu
            string passwordHash = HashPassword(password);

            // Đăng ký tài khoản
            RegisterAccount(phone, passwordHash);

            // Chuyển sang trang đăng nhập
            MessageBox.Show("Đăng ký thành công! Chuyển sang trang đăng nhập.");
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();

        }
        public void RegisterAccount(string phone, string passwordHash)
        {
            // Đảm bảo lấy đúng chuỗi kết nối từ app.config
            string connectionString = ConfigurationManager.ConnectionStrings["GCSManagerConnection"].ConnectionString;

            // Tạo salt ngẫu nhiên
            string salt = GenerateSalt();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Thêm cột Salt vào câu lệnh SQL
                string query = "INSERT INTO Account (Username, PasswordHash, Salt, Role) VALUES (@Phone, @PasswordHash, @Salt, '2')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm các tham số
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@Salt", salt);

                    // Thực thi lệnh
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Hàm tạo salt ngẫu nhiên
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }




        private bool isPasswordVisible = false;
        private void btnShowPassword_Click_1(object sender, EventArgs e)
        {
            // Chuyển đổi trạng thái hiển thị mật khẩu
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Hiển thị mật khẩu
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtPassword.PasswordChar = '*';

            }
        }

        private void btnShowConfirmPassword_Click_1(object sender, EventArgs e)
        {
            // Chuyển đổi trạng thái hiển thị mật khẩu
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Hiển thị mật khẩu
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtConfirmPassword.PasswordChar = '*';
            }
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void lblPhonenumber_Click(object sender, EventArgs e)
        {

        }

        private void lblEnterOTP_Click(object sender, EventArgs e)
        {

        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblCreateaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", đóng ứng dụng
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
                Application.Exit(); // Đóng toàn bộ ứng dụng
            }
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            LoginWithGoogle();
        }

        

       
    }

}



