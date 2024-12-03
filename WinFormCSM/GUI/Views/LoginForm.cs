using Services.ModelViews.LoginModelViews;
using Services;
using GUI.Views.DonHang;

namespace GUI.Views
{
    public partial class LoginForm : Form
    {
        private readonly LoginService _loginService;
        public LoginForm()
        {
            InitializeComponent();
            _loginService = new();
        }

        private async void login_Btn_Click(object sender, EventArgs e)
        {
            LoginRequest request = new()
            {
                Username = username_Txtbox.Text,
                Password = password_Txtbox.Text
            };

            if (await _loginService.Login(request))
            {
                DonHang.Index f = new();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
