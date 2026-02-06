using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdNoidungdieutri
{
    public double Id { get; set; }

    public double? Idpdt { get; set; }

    public double? Idcv { get; set; }

    public string? Tencv { get; set; }

    public string? Diengiai { get; set; }

    public double? Sl { get; set; }

    public double? Dongia { get; set; }

    public double? Tilegiam { get; set; }

    public double? Heso { get; set; }

    public double? Thanhtien { get; set; }

    public double? Tienlabo { get; set; }
}
