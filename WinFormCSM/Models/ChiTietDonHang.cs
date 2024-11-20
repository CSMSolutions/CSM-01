using System;
using System.Collections.Generic;

namespace Models;

public partial class ChiTietDonHang
{
    public int ChiTietDonHangId { get; set; }

    public int DonHangId { get; set; }

    public int SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public int? TinhTrangDanhGia { get; set; }

    public virtual DonHang DonHang { get; set; } = null!;

    public virtual ChiTietSanPham SanPham { get; set; } = null!;
}
