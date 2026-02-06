using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class NhanVien
{
    public double? Id { get; set; }

    public string? MaNhanVien { get; set; }

    public string? TenNhanVien { get; set; }

    public double? NhomBsktv { get; set; }

    public string? NhomDuoc { get; set; }

    public string? NhomKeToan { get; set; }

    public string? NhomPhuTa { get; set; }

    public string? NhomTiepTan { get; set; }

    public double? NhomKhac { get; set; }

    public string? Xoa { get; set; }

    public string? GhiChú { get; set; }
}
