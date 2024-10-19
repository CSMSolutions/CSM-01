using System;
using System.Collections.Generic;

namespace Models;

public partial class SanPham
{
    public int SanPhamId { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string? MoTa { get; set; }

    public decimal Gia { get; set; }

    public int SoLuongTonKho { get; set; }

    public int? DanhMucId { get; set; }

    public string? HinhAnhUrl { get; set; }

    public DateTime? NgayTao { get; set; }

    public bool? KichHoat { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual DanhMuc? DanhMuc { get; set; }

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual ICollection<PhanHoi> PhanHois { get; set; } = new List<PhanHoi>();
}
