using Models;
using System;
using System.Collections.Generic;

namespace Models;
public partial class DonHang
{
    public int DonHangId { get; set; }

    public int NguoiDungId { get; set; }

    public int? NhanVienId { get; set; }

    public int DiaChiId { get; set; }

    public decimal TongTien { get; set; }

    public string TinhTrangDonHang { get; set; } = null!;

    public DateTime? NgayDatHang { get; set; }

    public string HinhThucThanhToan { get; set; } = null!;

    public string TinhTrangThanhToan { get; set; } = null!;

    public DateTime? NgayThanhToan { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual ThongTinGiaoHang DiaChi { get; set; } = null!;

    public virtual NguoiDung NguoiDung { get; set; } = null!;

    public virtual NguoiDung? NhanVien { get; set; }
}
