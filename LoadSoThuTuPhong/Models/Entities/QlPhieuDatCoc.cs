using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDatCoc
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public long? Idbn { get; set; }

    public DateTime? NgayTao { get; set; }

    public long? Idnvtao { get; set; }

    public string? GhiChuTao { get; set; }

    public double? SoTien { get; set; }

    public double? SoTienSuDung { get; set; }

    public double? SoTienTra { get; set; }

    public DateTime? NgayTra { get; set; }

    public long? Idnvtra { get; set; }

    public string? GhiChuTra { get; set; }

    public virtual DmBenhNhan? IdbnNavigation { get; set; }

    public virtual DmNhanVien? IdnvtaoNavigation { get; set; }

    public virtual DmNhanVien? IdnvtraNavigation { get; set; }

    public virtual ICollection<QlThuTienDieuTriDatCoc> QlThuTienDieuTriDatCocs { get; set; } = new List<QlThuTienDieuTriDatCoc>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();
}
