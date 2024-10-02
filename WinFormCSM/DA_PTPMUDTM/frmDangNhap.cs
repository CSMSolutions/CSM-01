using frm_DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTPMUDTM
{
    public partial class frmDangNhap : Form
    {
        private frmMain _frmMain;
        public frmDangNhap()
        {
            InitializeComponent();
            var ucDangNhap = new UC_DangNhap(this);
            ucDangNhap.getChangeKQ += UcDangNhap_getChangeKQ;
            LoadUserControl(ucDangNhap);
        }

        private void UcDangNhap_getChangeKQ(object sender, EventArgs e)
        {
            _frmMain = new frmMain();
            _frmMain.Show();
            this.Hide();
        }

        private void LoadUserControl(UserControl userControl)
        {
            this.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
        }
        public void ShowForgotPasswordControl()
        {
            LoadUserControl(new UC_QuenMatKhau(this));
        }
        public void ShowLoginControl()
        {
            LoadUserControl(new UC_DangNhap(this));
        }

    }
}
