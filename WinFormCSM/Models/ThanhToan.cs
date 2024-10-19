using System;
using System.Collections.Generic;

namespace Models;

public partial class ThanhToan
{
    public int ThanhToanId { get; set; }

    public int DonHangId { get; set; }

    public string HinhThucThanhToan { get; set; } = null!;

    public string TinhTrangThanhToan { get; set; } = null!;

    public DateTime? NgayThanhToan { get; set; }

    public virtual DonHang DonHang { get; set; } = null!;
}
