using Models;

namespace Models;
public partial class PhanHoi
{
    public int PhanHoiId { get; set; }

    public int SanPhamId { get; set; }

    public int NguoiDungId { get; set; }

    public string? NoiDung { get; set; }

    public int? DanhGia { get; set; }

    public DateTime? NgayPhanHoi { get; set; }

    public virtual NguoiDung NguoiDung { get; set; } = null!;

    public virtual SanPham SanPham { get; set; } = null!;
}
