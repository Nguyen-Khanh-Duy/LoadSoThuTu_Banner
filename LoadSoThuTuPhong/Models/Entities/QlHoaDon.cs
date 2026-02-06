using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlHoaDon
{
    public long Id { get; set; }

    public DateTime? NgayHd { get; set; }

    public string? KyHieuHd { get; set; }

    public string? Seri { get; set; }

    public string? LoaiHd { get; set; }

    public string? SoHd { get; set; }

    public long? IdnhanVienTao { get; set; }

    public long? Idcn { get; set; }

    public long? Idkip { get; set; }

    public string? Mst { get; set; }

    public string? TenDn { get; set; }

    public string? DiaChiDn { get; set; }

    public string? EmailHd { get; set; }

    public DateTime? NgayLapHd { get; set; }

    public string? GhiChu { get; set; }

    public long? IdphieuThuTien { get; set; }

    public bool? Active { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmKip? IdkipNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienTaoNavigation { get; set; }

    public virtual QlThuTienDieuTri? IdphieuThuTienNavigation { get; set; }

    public virtual ICollection<QlHoaDonCt> QlHoaDonCts { get; set; } = new List<QlHoaDonCt>();
}
