using System;
using System.Collections.Generic;

namespace Models;

public partial class ChiTietSanPham
{
    public int ChiTietSanPhamId { get; set; }

    public int? SanPhamId { get; set; }

    public int? SizeId { get; set; }

    public int? MauId { get; set; }

    public decimal Gia { get; set; }

    public int SoLuongTonKho { get; set; }

    public string? HinhAnhUrl { get; set; }

    public bool? KichHoat { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual Mau? Mau { get; set; }

    public virtual SanPham? SanPham { get; set; }

    public virtual Size? Size { get; set; }
}
