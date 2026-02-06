using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdSocot
{
    public int Id { get; set; }

    public double? Manhom { get; set; }

    public string? Tennhom { get; set; }

    public string? Kyhieu { get; set; }

    public int? Stt { get; set; }

    public int? Tm { get; set; }
}
