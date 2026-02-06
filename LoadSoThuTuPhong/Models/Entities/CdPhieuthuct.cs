using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdPhieuthuct
{
    public double Id { get; set; }

    public long? Maso { get; set; }

    public string? Maloai { get; set; }

    public string? Ghichu { get; set; }

    public double? Sotien { get; set; }

    public double? Heso { get; set; }

    public double? Labo { get; set; }

    public double? Bsgm { get; set; }
}
