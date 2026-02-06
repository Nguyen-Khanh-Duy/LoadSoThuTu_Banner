using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdSolabo
{
    public double Stt { get; set; }

    public long? Idphieu { get; set; }

    public double? Ptid { get; set; }

    public DateTime? Ngaylap { get; set; }

    public DateTime? Ngay { get; set; }

    public double? Sotien { get; set; }

    public string? Kip { get; set; }

    public string? Nguoilap { get; set; }

    public double? Datra { get; set; }

    public double? Conno { get; set; }

    public long? Idncc { get; set; }

    public long? Idnv { get; set; }

    public int? Bstl { get; set; }

    public long? Idbn { get; set; }
}
