using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace DAL
{
    public class DAL_DangNhap
    {
        CSMDataContext db = new CSMDataContext();
        public DAL_DangNhap() { }
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
        
    }
}
