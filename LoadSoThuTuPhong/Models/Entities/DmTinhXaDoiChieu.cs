using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTinhXaDoiChieu
{
    public long Id { get; set; }

    public string? MaXaCu { get; set; }

    public string? MaXaMoi { get; set; }

    public string? MaTinhMoi { get; set; }

    public bool? Active { get; set; }
}
