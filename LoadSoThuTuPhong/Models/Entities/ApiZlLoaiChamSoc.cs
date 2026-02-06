using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class ApiZlLoaiChamSoc
{
    public long Id { get; set; }

    public string? MaLoaiChamSoc { get; set; }

    public string? TenLoaiChamSoc { get; set; }

    public string? MauTemplate { get; set; }

    public bool? Active { get; set; }
}
