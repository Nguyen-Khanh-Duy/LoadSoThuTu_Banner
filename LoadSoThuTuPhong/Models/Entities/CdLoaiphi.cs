using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdLoaiphi
{
    public double Id { get; set; }

    public string? Maloai { get; set; }

    public string? Tenloai { get; set; }

    public string? Kyhieu { get; set; }

    public double? Heso { get; set; }

    public double? Tien { get; set; }

    public string? Nameid { get; set; }

    public int? Manhom { get; set; }
}
