using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmHinhThucThanhToan
{
    public long Id { get; set; }

    public string? TenHinhThucThanhToan { get; set; }

    public bool? Active { get; set; }

    public bool? Online { get; set; }

    public virtual ICollection<QlPhieuThuNo> QlPhieuThuNos { get; set; } = new List<QlPhieuThuNo>();

    public virtual ICollection<QlPhieuTraNo> QlPhieuTraNos { get; set; } = new List<QlPhieuTraNo>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();
}
