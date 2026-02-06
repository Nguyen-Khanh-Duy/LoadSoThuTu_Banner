using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtTiLe
{
    public long Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public double? TiLe { get; set; }
}
