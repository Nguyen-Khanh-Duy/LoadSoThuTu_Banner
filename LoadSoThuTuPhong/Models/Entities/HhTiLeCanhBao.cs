using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhTiLeCanhBao
{
    public long Id { get; set; }

    public string? TenTiLe { get; set; }

    public double? TiLe { get; set; }
}
