using Models;

namespace Models;

public partial class KhuyenMai
{
    public int MaKhuyenMai { get; set; }

    public string? TenChuongTrinhKm { get; set; }

    public int? MucGiam { get; set; }

    public string? MoTa { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; } = new List<ChiTietKhuyenMai>();
}
