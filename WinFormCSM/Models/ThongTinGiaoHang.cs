using System;
using System.Collections.Generic;

namespace Models;

public partial class ThongTinGiaoHang
{
    public int DiaChiId { get; set; }

    public int NguoiDungId { get; set; }

    public string TenNguoiNhan { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string DiaChiGiaoHang { get; set; } = null!;

    public bool? DiaChiMacDinh { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual NguoiDung NguoiDung { get; set; } = null!;
}
