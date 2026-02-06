using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNganHangDoanhNghiep
{
    public long Id { get; set; }

    public long? IdchiNhanh { get; set; }

    public long? IdnganHang { get; set; }

    public string? Stk { get; set; }

    public string? TenChuTk { get; set; }

    public bool? Active { get; set; }

    public virtual DmChiNhanh? IdchiNhanhNavigation { get; set; }

    public virtual HhDmNganHang? IdnganHangNavigation { get; set; }

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();
}
