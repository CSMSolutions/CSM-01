using System;
using System.Collections.Generic;

namespace Models;

public partial class NguoiDung
{
    public int NguoiDungId { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? Email { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? SoThich { get; set; }

    public string? VaiTro { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? PhanKhucKh { get; set; }

    public bool? Train { get; set; }

    public string? GioiTinh { get; set; }

    public int? MucChiTieu { get; set; }

    public int? DoTuoi { get; set; }

    public bool? KichHoat { get; set; }

    public virtual ICollection<DonHang> DonHangNguoiDungs { get; set; } = new List<DonHang>();

    public virtual ICollection<DonHang> DonHangNhanViens { get; set; } = new List<DonHang>();

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual ICollection<PhanHoi> PhanHois { get; set; } = new List<PhanHoi>();

    public virtual ICollection<ThongTinGiaoHang> ThongTinGiaoHangs { get; set; } = new List<ThongTinGiaoHang>();
}
