using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuChi
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayTaoPhieu { get; set; }

    public long? IdnhanVienTao { get; set; }

    public bool? DaHuy { get; set; }

    public string? GhiChu { get; set; }

    public long? Idcn { get; set; }

    public string? NguoiNhanTien { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienTaoNavigation { get; set; }

    public virtual ICollection<QlPhieuChiCt> QlPhieuChiCts { get; set; } = new List<QlPhieuChiCt>();
}
