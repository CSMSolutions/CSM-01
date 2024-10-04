using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static DAL.DAL_DangNhap;

namespace DA_PTPMUDTM
{
    public partial class frmQuenMatKhau : Form
    {
        BLL_DangNhap xl = new BLL_DangNhap();
        private frmDangNhap _frmDangNhap;
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        private bool isPasswordVisible = false;

        private void pbMatKhauCu_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhauCu.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void pbMatKhauMoi_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhauMoi.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng không để trống các trường thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KetQuaDN ketQua = xl.XuLyQuenMatKhau(tenDN, matKhauCu, matKhauMoi);

            switch (ketQua)
            {
                case KetQuaDN.Rong:
                    MessageBox.Show("Vui lòng không để trống tên đăng nhập và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case KetQuaDN.KhongTonTai:
                    MessageBox.Show("Người dùng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case KetQuaDN.MatKhauKhongChinhXac:
                    MessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case KetQuaDN.ThanhCongCapNhat:
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmDangNhap = new frmDangNhap();
                    _frmDangNhap.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Đã xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            _frmDangNhap = new frmDangNhap();
            _frmDangNhap.Show();
            this.Hide();
        }
    }
}
