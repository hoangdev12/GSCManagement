using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2.Data;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class ResetPassword : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["GCSManagerConnection"].ConnectionString;
        private string clientId = "579771809210-7hgf5bnv3126pj7v685ti3ilk492ule8.apps.googleusercontent.com";
        private string clientSecret = "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";
        public ResetPassword()
        {
            InitializeComponent();
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
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void lblCreateaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
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
        public class PasswordReset
        {
            private string connectionString = "chuỗi_kết_nối_của_bạn";

            // Phương thức để băm mật khẩu với salt
            private string HashPassword(string password, string salt)
            {
                using (var sha256 = SHA256.Create())
                {
                    var saltedPassword = password + salt;
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                    return Convert.ToBase64String(bytes);
                }
            }

        }
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        private string HashPassword(string password, string salt)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword == confirmPassword)
            {
                string salt = GenerateSalt();
                string hashedPassword = HashPassword(newPassword, salt);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Account SET PasswordHash = @PasswordHash, Salt = @Salt WHERE Username = @PhoneNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@Salt", salt);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mật khẩu đã được đặt lại thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại không tồn tại.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
            }
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            LoginWithGoogle();
        }
    }
}
