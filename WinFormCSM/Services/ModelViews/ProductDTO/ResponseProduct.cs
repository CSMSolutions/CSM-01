using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelViews.ProductDTO
{
    public class ResponseProduct
    {
        public int SanPhamId { get; set; }

        public string TenSanPham { get; set; } = null!;

        public int? SoSaoTb { get; set; }

        public string DanhMuc { get; set; } = null!;

        public string KichHoat { get; set; } = null!;
    }
}
