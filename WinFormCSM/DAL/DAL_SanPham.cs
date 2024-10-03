using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_SanPham
    {
        CSMDataContext db = new CSMDataContext();
        public DAL_SanPham()
        {

        }
        public List<SanPham> GetDanhSachSanPham()
        {
            return db.SanPhams.Select(sp => sp).ToList<SanPham>();
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
