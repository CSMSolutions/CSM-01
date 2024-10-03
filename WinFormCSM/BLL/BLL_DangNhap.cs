using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_DangNhap
    {
        DAL_DangNhap dal = new DAL_DangNhap();
        public BLL_DangNhap() { }

        // Hàm kiểm tra đăng nhập
        public DAL_DangNhap.KetQuaDN KiemTraDangNhap(string tenDN, string matKhau)
        {
            return dal.checkDangNhap(tenDN, matKhau);
        }

        // Hàm xử lý quên mật khẩu
        public DAL_DangNhap.KetQuaDN XuLyQuenMatKhau(string tenDN, string matKhauCu, string matKhauMoi)
        {
            return dal.quenMK(tenDN, matKhauCu, matKhauMoi);
        }

    }
}
