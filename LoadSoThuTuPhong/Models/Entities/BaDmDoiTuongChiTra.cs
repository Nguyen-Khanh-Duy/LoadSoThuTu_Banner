using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class BaDmDoiTuongChiTra
{
    public long Id { get; set; }

    public string? MaDoiTuong { get; set; }

    public string? TenDoiTuong { get; set; }
}
