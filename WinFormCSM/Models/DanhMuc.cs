﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class DanhMuc
{
    public int DanhMucId { get; set; }

    public string TenDanhMuc { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
