using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDuTru
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public long? IdchiNhanhDuTru { get; set; }

    public DateTime? ThoiGianDuTru { get; set; }

    public long? IdnhanVienDuTru { get; set; }

    public long? IdnhanVien { get; set; }

    public string? GhiChu { get; set; }

    public virtual DmChiNhanh? IdchiNhanhDuTruNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienDuTruNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }

    public virtual ICollection<QlPhieuDuTruCt> QlPhieuDuTruCts { get; set; } = new List<QlPhieuDuTruCt>();
}
