using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using static ThuVien.XuLy;
using DA_PTPMUDTM;

namespace frm_DangNhap
{
    public partial class UC_QuenMatKhau : UserControl
    {
        XuLy xl = new XuLy();

        private frmDangNhap _mainForm;
        public UC_QuenMatKhau(frmDangNhap mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private bool isPasswordVisible = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhauCu.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhauMoi.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            KetQuaDN ketQua = xl.quenMK(tenDN, matKhauCu, matKhauMoi);
            switch (ketQua)
            {
                case KetQuaDN.Rong:
                    MessageBox.Show("Vui lòng không để trống tên đăng nhập và mật khẩu!");
                    break;
                case KetQuaDN.KhongTonTai:
                    MessageBox.Show("Người dùng không tồn tại.");
                    break;
                case KetQuaDN.MatKhauKhongChinhXac:
                    MessageBox.Show("Mật khẩu cũ không chính xác.");
                    break;
                case KetQuaDN.ThanhCongCapNhat:
                    MessageBox.Show("Cập nhật mật khẩu thành công!");
                    break;
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginControl();
        }
    }
}
