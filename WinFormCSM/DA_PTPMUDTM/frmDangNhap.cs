using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace DA_PTPMUDTM
{
    public partial class frmDangNhap : Form
    {
        private BLL_DangNhap xl = new BLL_DangNhap();
        private frmMain _frmMain;
        private frmQuenMatKhau _frmQuenMatKhau;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtTenDN.Text;
            string mk = txtMatKhau.Text;
            var kq = xl.KiemTraDangNhap(ten, mk);
            switch (kq)
            {
                case DAL_DangNhap.KetQuaDN.ThanhCong:
                    MessageBox.Show("Chúc mừng bạn đăng nhập thành công!");
                    _frmMain = new frmMain();
                    _frmMain.Show();
                    this.Hide();
                    break;

                case DAL_DangNhap.KetQuaDN.SaiThongTin:
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    break;

                case DAL_DangNhap.KetQuaDN.KhongPhaiAdmin:
                    MessageBox.Show("Chỉ có admin mới được phép đăng nhập!");
                    break;

                case DAL_DangNhap.KetQuaDN.Rong:
                    MessageBox.Show("Vui lòng không để trống tên đăng nhập và mật khẩu!");
                    break;

                default:
                    MessageBox.Show("Đăng nhập thất bại!");
                    break;
            }
        }

        private void labQuenMatKhau_Click(object sender, EventArgs e)
        {
            _frmQuenMatKhau = new frmQuenMatKhau();
            _frmQuenMatKhau.Show();
            this.Hide();
        }
        private bool isXemMatKhau = false;
        private void pbMatKhau_Click(object sender, EventArgs e)
        {
            isXemMatKhau = !isXemMatKhau;
            txtMatKhau.UseSystemPasswordChar = !isXemMatKhau;
        }
    }
}
