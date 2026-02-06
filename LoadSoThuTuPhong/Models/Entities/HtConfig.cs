using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtConfig
{
    public long Id { get; set; }

    public string? MaChucNang { get; set; }

    public bool? HieuLuc { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? Ngay { get; set; }
}
