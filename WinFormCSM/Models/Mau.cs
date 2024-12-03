using Models;

namespace Models;

public partial class Mau
{
    public int MauId { get; set; }

    public string MauName { get; set; } = null!;

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
