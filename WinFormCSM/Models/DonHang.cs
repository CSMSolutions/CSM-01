using System;
using System.Collections.Generic;

namespace Models;

public partial class DonHang
{
    public int DonHangId { get; set; }

    public int NguoiDungId { get; set; }

    public decimal TongTien { get; set; }

    public string TinhTrangDonHang { get; set; } = null!;

    public DateTime? NgayDatHang { get; set; }

    public string? DiaChiGiaoHang { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual NguoiDung NguoiDung { get; set; } = null!;

    public virtual ICollection<ThanhToan> ThanhToans { get; set; } = new List<ThanhToan>();
}
