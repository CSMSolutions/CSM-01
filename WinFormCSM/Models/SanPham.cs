namespace Models;

public partial class SanPham
{
    public int SanPhamId { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string? MoTa { get; set; }

    public int? SoLuongDaBan { get; set; }

    public int? SoSaoTb { get; set; }

    public int? DanhMucId { get; set; }

    public bool? KichHoat { get; set; }

    public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; } = new List<ChiTietKhuyenMai>();

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();

    public virtual DanhMuc? DanhMuc { get; set; }

    public virtual ICollection<PhanHoi> PhanHois { get; set; } = new List<PhanHoi>();
}
