using Models;

namespace Models;

public partial class ChiTietKhuyenMai
{
    public int ChiTietKhuyenMaiId { get; set; }

    public int? SanPhamId { get; set; }

    public int? KhuyenMaiId { get; set; }

    public bool? DaHetHan { get; set; }

    public virtual KhuyenMai? KhuyenMai { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
