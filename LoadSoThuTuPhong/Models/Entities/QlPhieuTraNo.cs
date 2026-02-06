using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuTraNo
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayNhap { get; set; }

    public long? Idncc { get; set; }

    public long? Idcnxuat { get; set; }

    public long? Idhttt { get; set; }

    public string? NguoiNhanTien { get; set; }

    public string? GhiChu { get; set; }

    public string? Stk { get; set; }

    public long? Idnv { get; set; }

    public long? Idcn { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmChiNhanh? IdcnxuatNavigation { get; set; }

    public virtual DmHinhThucThanhToan? IdhtttNavigation { get; set; }

    public virtual HhDmNhaCungCap? IdnccNavigation { get; set; }

    public virtual DmNhanVien? IdnvNavigation { get; set; }

    public virtual ICollection<QlPhieuTraNoCt> QlPhieuTraNoCts { get; set; } = new List<QlPhieuTraNoCt>();
}
