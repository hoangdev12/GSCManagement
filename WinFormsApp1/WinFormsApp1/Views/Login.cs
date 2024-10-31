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
using Google.Apis.Oauth2.v2.Data;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace WinFormsApp1.Views
{
    public partial class Login : Form
    {
        private string clientId = "579771809210-7hgf5bnv3126pj7v685ti3ilk492ule8.apps.googleusercontent.com";
        private string clientSecret = "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";
        public Login()
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
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword ResetPasswordForm = new ResetPassword();
            ResetPasswordForm.Show();
            this.Hide();
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
        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtSignin.Text;
            string password = txtPassword.Text;

            // Kiểm tra các trường có được điền đầy đủ không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Hash mật khẩu mà người dùng nhập vào để so sánh với mật khẩu đã mã hóa trong DB
            string passwordHash = HashPassword(password);

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = ConfigurationManager.ConnectionStrings["GCSManagerConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Account WHERE Username = @Username AND PasswordHash = @PasswordHash";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Đăng nhập thành công
                        //  MessageBox.Show("Đăng nhập thành công!");

                        // Mở form khác (nếu có)
                        Form newForm = new Admin();
                        newForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Sai tên đăng nhập hoặc mật khẩu
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.");
                    }
                }
            }
        }
        private bool isPasswordVisible = false;
        private void btnShowPasswordLogin_Click(object sender, EventArgs e)
        {
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

        private void lblCreateaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SignUp SignUpForm = new SignUp();
            SignUpForm.Show();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtSignin_TextChanged(object sender, EventArgs e)
        {

        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Đảm bảo thoát hoàn toàn ứng dụng
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            LoginWithGoogle();
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
