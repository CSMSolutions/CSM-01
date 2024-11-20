using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelViews.ProductModelViews
{
    public class ProductDetailView
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongTonKho { get; set; }
        public decimal GiaTien { get; set; }
        public decimal TongTienSanPham { get; set; }
    }
}
