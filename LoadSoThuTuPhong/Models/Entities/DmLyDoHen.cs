using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmLyDoHen
{
    public long Id { get; set; }

    public string? LyDoHen { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlHen> QlHens { get; set; } = new List<QlHen>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();
}
