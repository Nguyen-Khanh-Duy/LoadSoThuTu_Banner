using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmKhungGioHen
{
    public long Id { get; set; }

    public string? TenKhungGio { get; set; }

    public string? Stt { get; set; }

    public bool? Sang { get; set; }

    public bool? Trua { get; set; }

    public bool? Chieu { get; set; }

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();
}
