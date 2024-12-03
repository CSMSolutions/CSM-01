using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.ModelViews.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService
    {
        private readonly GenericRepository<SanPham> sanPhamRepository;
        public ProductService()
        {
            sanPhamRepository = new GenericRepository<SanPham>();
        }

        public async Task<List<ResponseProduct>> GetAllProduct()
        {
            List<ResponseProduct> responses = await sanPhamRepository.Entities.Select(_ => new ResponseProduct()
            {
                SanPhamId = _.SanPhamId,
                TenSanPham = _.TenSanPham,
                SoSaoTb = _.SoSaoTb,
                DanhMuc = _.DanhMuc != null ? _.DanhMuc.TenDanhMuc : "",
                KichHoat = _.KichHoat == true ? "Đang hoạt động" : "Dừng hoạt động"
            }).OrderBy(_ => _.KichHoat == "Đang hoạt động").ThenBy(_ => _.SanPhamId).ToListAsync();
            return responses;
        }

        public async Task<List<ResponseProduct>> Search(string searchText)
        {
            bool isNumeric = int.TryParse(searchText, out int productId);

            List<ResponseProduct> responses = await sanPhamRepository.Entities
                .Where(_ => _.TenSanPham.Contains(searchText) ||
                            (_.DanhMuc != null && _.DanhMuc.TenDanhMuc.Contains(searchText)) ||
                            (isNumeric && _.SanPhamId == productId)) // Thêm điều kiện tìm theo SanPhamId
                .Select(_ => new ResponseProduct()
                {
                    SanPhamId = _.SanPhamId,
                    TenSanPham = _.TenSanPham,
                    SoSaoTb = _.SoSaoTb,
                    DanhMuc = _.DanhMuc != null ? _.DanhMuc.TenDanhMuc : "",
                    KichHoat = _.KichHoat == true ? "Đang hoạt động" : "Dừng hoạt động"
                })
                .OrderBy(_ => _.KichHoat == "Đang hoạt động")
                .ThenBy(_ => _.SanPhamId)
                .ToListAsync();

            return responses;
        }

    }
}
