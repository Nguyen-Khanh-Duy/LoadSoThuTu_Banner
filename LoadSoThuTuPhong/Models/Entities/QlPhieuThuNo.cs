using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuThuNo
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayLap { get; set; }

    public long? Idkh { get; set; }

    public long? Idcnnhap { get; set; }

    public long? Idhttt { get; set; }

    public string? NguoiTraTien { get; set; }

    public string? Stk { get; set; }

    public string? GhiChu { get; set; }

    public long? Idnv { get; set; }

    public long? Idcn { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmChiNhanh? IdcnnhapNavigation { get; set; }

    public virtual DmHinhThucThanhToan? IdhtttNavigation { get; set; }

    public virtual DmNhanVien? IdnvNavigation { get; set; }

    public virtual ICollection<QlPhieuThuNoCt> QlPhieuThuNoCts { get; set; } = new List<QlPhieuThuNoCt>();
}
