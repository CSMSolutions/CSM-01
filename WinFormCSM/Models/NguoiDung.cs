using System;
using System.Collections.Generic;

namespace Models;

public partial class NguoiDung
{
    public int NguoiDungId { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? SoThich { get; set; }

    public string? VaiTro { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? PhanKhucKh { get; set; }

    public bool? Train { get; set; }

    public bool? KichHoat { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual ICollection<PhanHoi> PhanHois { get; set; } = new List<PhanHoi>();
}
