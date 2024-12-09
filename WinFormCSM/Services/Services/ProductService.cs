using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.ModelViews.ProductDTO;
using Services.ModelViews.ProductModelViews;
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
        private readonly GenericRepository<DanhMuc> danhMucRepository;
        private readonly GenericRepository<ChiTietSanPham> chiTietRepository;
        private readonly GenericRepository<Size> sizeRepository;
        private readonly GenericRepository<Mau> mauRepository;

        public ProductService()
        {
            sanPhamRepository = new GenericRepository<SanPham>();
            danhMucRepository = new GenericRepository<DanhMuc>();
            chiTietRepository = new GenericRepository<ChiTietSanPham>();
            sizeRepository = new();
            mauRepository = new();
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

        public SanPham? GetProductById(int id)
        {
            SanPham? sp = sanPhamRepository.Entities.Include(_ => _.ChiTietSanPhams).FirstOrDefault(_ => _.SanPhamId == id);
            return sp;
        }

        public List<string> GetAllCategoryName()
        {
            List<string> list = danhMucRepository.GetAll().Select(_ => _.TenDanhMuc).ToList();
            return list;
        }

        public List<ResponseProductDetail> GetProductDetailByProduct(int productId)
        {
            List<ResponseProductDetail> list = chiTietRepository.Entities
                .Where(_ => _.SanPhamId == productId)
                .Select(_ => new ResponseProductDetail()
                {
                    ChiTietSanPhamId = _.ChiTietSanPhamId,
                    MauName = _.Mau != null ? _.Mau.MauName : "N/A",
                    SizeName = _.Size != null ? _.Size.SizeName : "N/A",
                    DonGia = _.Gia,
                    SoLuong = _.SoLuongTonKho,
                    KichHoat = _.KichHoat == true ? "Đang hoạt động" : "Dừng hoạt động",
                    HinhAnh = $"E:\\HUIT\\HK2_2024_2025\\PTPM\\Web_DoAn_2\\CSM02-WEB\\DoAnChuyenNganh\\img\\{_.HinhAnhUrl}" // Tạo đường dẫn đầy đủ
                }).OrderBy(_ => _.KichHoat == "Dừng hoạt động").ToList();
            return list;
        }

        public async Task<bool> UpdateProduct(int id, UpdateProductDTO dto)
        {
            try
            {
                DanhMuc dm = danhMucRepository.Entities.FirstOrDefault(_ => _.TenDanhMuc == dto.Category) ?? throw new Exception();
                SanPham sp = sanPhamRepository.Entities.FirstOrDefault(_ => _.SanPhamId == id) ?? throw new Exception();
                sp.DanhMucId = dm.DanhMucId;
                sp.TenSanPham = dto.Name;
                sp.MoTa = dto.Discription;
                await sanPhamRepository.UpdateAsync(sp);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task UpdateProductActivation(int productId, bool newState)
        {
            try
            {
                SanPham sp = sanPhamRepository.Entities.FirstOrDefault(_ => _.SanPhamId == productId) ?? throw new Exception();
                sp.KichHoat = newState;
                await sanPhamRepository.UpdateAsync(sp);
            } catch
            {
                throw new Exception("Cập nhật thất bại");
            }
        }

        public async Task<bool> AddProduct(CreateProductDTO dto)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(dto.Name) || string.IsNullOrWhiteSpace(dto.Discription))
                {
                    return false;
                }
                if(sanPhamRepository.Entities.Any(_ => _.TenSanPham == dto.Name))
                {
                    return false;
                }
                DanhMuc dm = danhMucRepository.Entities.FirstOrDefault(_ => _.TenDanhMuc == dto.DanhMuc) ?? throw new Exception();
                SanPham sp = new SanPham()
                {
                    TenSanPham = dto.Name,
                    MoTa = dto.Discription,
                    DanhMucId = dm.DanhMucId,
                };
                await sanPhamRepository.InsertAsync(sp);
                return true;
            } catch
            {
                return false;
            }
        }

        public List<string> GetAllSizeName()
        {
            return sizeRepository.Entities.Select(_ => _.SizeName).ToList();
        }

        public List<string> GetAllMauName()
        {
            return mauRepository.Entities.Select(_ => _.MauName).ToList();
        }

        public async Task<bool> AddProductDetail(CreateProductDetailDTO dto, string sourceImagePath)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(sourceImagePath) || dto.Gia <= 0 || dto.SoLuongTonKho <= 0)
                {
                    return false;
                }

                string fileName = Path.GetFileName(sourceImagePath);
                string destinationPath = Path.Combine("E:\\HUIT\\HK2_2024_2025\\PTPM\\Web_DoAn_2\\CSM02-WEB\\DoAnChuyenNganh\\img\\", fileName);

                if (!File.Exists(destinationPath))
                {
                    File.Copy(sourceImagePath, destinationPath, overwrite: true);
                }

                Size size = sizeRepository.Entities.FirstOrDefault(_ => _.SizeName == dto.Size) ?? throw new Exception("Không tìm thấy Size");
                Mau mau = mauRepository.Entities.FirstOrDefault(_ => _.MauName == dto.Mau) ?? throw new Exception("Không tìm thấy Màu");


                ChiTietSanPham cts = new ChiTietSanPham()
                {
                    SanPhamId = dto.SanPhamId,
                    SizeId = size.SizeId,
                    MauId = mau.MauId,
                    Gia = dto.Gia,
                    SoLuongTonKho = dto.SoLuongTonKho,
                    HinhAnhUrl = fileName // Chỉ lưu tên file
                };

                await chiTietRepository.InsertAsync(cts);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task UpdateProductDetailActivation(int productId, bool newState)
        {
            try
            {
                ChiTietSanPham sp = chiTietRepository.Entities.FirstOrDefault(_ => _.ChiTietSanPhamId == productId) ?? throw new Exception();
                sp.KichHoat = newState;
                await chiTietRepository.UpdateAsync(sp);
            }
            catch
            {
                throw new Exception("Cập nhật thất bại");
            }
        }
    }
}
