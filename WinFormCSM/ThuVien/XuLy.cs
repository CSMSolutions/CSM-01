using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public class XuLy
    {
        CSM_DBDataContext db = new CSM_DBDataContext();
        public XuLy() { }

        public enum KetQuaDN
        {
            ThanhCong,
            SaiThongTin,
            KhongPhaiAdmin,
            Rong,
            MatKhauKhongChinhXac,
            KhongTonTai,
            ThanhCongCapNhat
        }

        public KetQuaDN checkDangNhap(string tenDN, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau))
            {
                return KetQuaDN.Rong;
            }
            try
            {
                // Tìm người dùng có tên đăng nhập và mật khẩu tương ứng
                var user = db.NguoiDungs
                             .Where(u => u.TenDangNhap == tenDN && u.MatKhau == matKhau)
                             .FirstOrDefault();
                if (user != null)
                {
                    return user.VaiTro == "Admin" ? KetQuaDN.ThanhCong : KetQuaDN.KhongPhaiAdmin;
                }
                return KetQuaDN.SaiThongTin;
            }
            catch (Exception)
            {
                return KetQuaDN.SaiThongTin;
            }
        }

        public KetQuaDN quenMK(string tenDN, string matKhauCu, string matKhauMoi)
        {
            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhauCu) || string.IsNullOrWhiteSpace(matKhauMoi))
            {
                return KetQuaDN.Rong;
            }
            var user = db.NguoiDungs
                .FirstOrDefault(u => u.TenDangNhap == tenDN);
            if (user == null)
            {
                return KetQuaDN.KhongTonTai;
            }
            if (user.MatKhau != matKhauCu)
            {
                return KetQuaDN.MatKhauKhongChinhXac;
            }
            user.MatKhau = matKhauMoi;
            db.SubmitChanges();
            return KetQuaDN.ThanhCongCapNhat;
        }
        public List<SanPham> GetDanhSachSanPham()
        {
           return  db.SanPhams.Select(sp => sp).ToList<SanPham>();
        }
        public List<DanhMuc> GetDanhSachDanhMucSP()
        {
            return db.DanhMucs.Select(dm => dm).ToList<DanhMuc>();
        }
        public List<SanPham> TimKiemSanPhamTheoTen(string tenSanPham)
        {
            if (string.IsNullOrWhiteSpace(tenSanPham))
            {
                return new List<SanPham>();
            }
            string pattern = $"%{tenSanPham}%";
            return db.SanPhams
                     .Where(sp => SqlMethods.Like(sp.TenSanPham, pattern))
                     .ToList();
        }
        public List<SanPham> GetDanhSachSanPhamTheoDanhMuc(string tenDanhMuc)
        {
            return db.SanPhams
                     .Where(sp => sp.DanhMuc.TenDanhMuc == tenDanhMuc)
                     .ToList();
        }


    }
}
