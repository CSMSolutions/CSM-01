using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using DA_PTPMUDTM;

namespace frm_DangNhap
{
    public partial class UC_DangNhap: UserControl
    {
        XuLy xl = new XuLy();
        private frmDangNhap _frmDangNhap;
        private frmMain _frmMain;
        public event EventHandler getChangeKQ;
        public UC_DangNhap(frmDangNhap frmDangNhap)
        {
            InitializeComponent();
            _frmDangNhap = frmDangNhap;
        }

        public UC_DangNhap()
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            string ten = txtTenDN.Text;
            string mk = txtMatKhau.Text;
            XuLy.KetQuaDN kq = xl.checkDangNhap(ten,mk);
            switch (kq)
            {
                case XuLy.KetQuaDN.ThanhCong:
                    MessageBox.Show("Chúc mừng bạn đăng nhập thành công!");
                    getChangeKQ.Invoke(this, EventArgs.Empty);
                    break;
                case XuLy.KetQuaDN.SaiThongTin:
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    break;
                case XuLy.KetQuaDN.KhongPhaiAdmin:
                    MessageBox.Show("Chỉ có admin mới được phép đăng nhập!");
                    break;
                case XuLy.KetQuaDN.Rong:
                    MessageBox.Show("Vui lòng không để trống tên đăng nhập và mật khẩu!");
                    break;
            }
        }
        private bool isPasswordVisible = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhau.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            _frmDangNhap.ShowForgotPasswordControl();
        }
    }
}
