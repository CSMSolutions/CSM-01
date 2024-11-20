using System;
using System.Collections.Generic;

namespace Models;

public partial class GioHang
{
    public int GioHangId { get; set; }

    public int NguoiDungId { get; set; }

    public int SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public virtual NguoiDung NguoiDung { get; set; } = null!;

    public virtual ChiTietSanPham SanPham { get; set; } = null!;
}
