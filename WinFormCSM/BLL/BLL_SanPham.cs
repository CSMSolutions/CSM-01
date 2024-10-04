using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace ThuVien
{
    public class BLL_SanPham
    {
        DAL_SanPham dal = new DAL_SanPham();
        public BLL_SanPham()
        {

        }
        // Hàm lấy danh sách sản phẩm
        public List<SanPham> LayDanhSachSanPham()
        {
            return dal.GetDanhSachSanPham();
        }

        // Hàm lấy danh sách danh mục sản phẩm
        public List<DanhMuc> LayDanhSachDanhMucSP()
        {
            return dal.GetDanhSachDanhMucSP();
        }

        // Hàm tìm kiếm sản phẩm theo tên
        public List<SanPham> TimKiemSanPhamTheoTen(string tenSanPham)
        {
            return dal.TimKiemSanPhamTheoTen(tenSanPham);
        }

        // Hàm lấy danh sách sản phẩm theo danh mục
        public List<SanPham> LayDanhSachSanPhamTheoDanhMuc(string tenDanhMuc)
        {
            return dal.GetDanhSachSanPhamTheoDanhMuc(tenDanhMuc);
        }


    }
}
