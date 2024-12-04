using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelViews.ProductDTO
{
    public class ResponseProductDetail
    {
        public string SizeName { get; set; } = null!;
        public string MauName { get; set; } = null!;
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
    }

    public class UpdateProductDTO
    {
        public string Name { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Discription { get; set; } = null!;
    }

    public class CreateProductDTO
    {
        public string Name { get; set; } = null!;
        public string Discription { get; set; } = null!;
        public string DanhMuc { get; set; } = null!;
    }

    public class UpdateProductDetail
    {

    }
}
