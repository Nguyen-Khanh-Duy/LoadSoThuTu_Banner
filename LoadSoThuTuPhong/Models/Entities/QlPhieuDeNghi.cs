using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDeNghi
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayDeNghi { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdNhanVienDeNghi { get; set; }

    public string? GhiChu { get; set; }

    public long? Idcn { get; set; }

    public virtual DmNhanVien? IdNhanVienDeNghiNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlPhieuDeNghiCt> QlPhieuDeNghiCts { get; set; } = new List<QlPhieuDeNghiCt>();
}
