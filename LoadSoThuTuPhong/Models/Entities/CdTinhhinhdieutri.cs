using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdTinhhinhdieutri
{
    public long Id { get; set; }

    public double Ptid { get; set; }

    public string? Ptname { get; set; }

    public string? Mabn { get; set; }

    public double Idnv { get; set; }

    public string? Ename { get; set; }

    public int? Kip { get; set; }

    public DateTime? Ngay { get; set; }

    public double? Dtid { get; set; }

    public double? Jid { get; set; }

    public string? Jname { get; set; }

    public string? Rang { get; set; }

    public double? Sotiendieutri { get; set; }

    public double? Sotientra { get; set; }
}
