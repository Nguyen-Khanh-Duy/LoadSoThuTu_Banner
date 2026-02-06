using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlKeHoachDieuTri
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdchiNhanh { get; set; }

    public DateTime? Ngay { get; set; }

    public long? IdbacSi { get; set; }

    public bool? HieuLuc { get; set; }

    public long? Idtt { get; set; }

    public long? Idkip { get; set; }

    public long? IdsinhVien { get; set; }

    public virtual DmNhanVien? IdbacSiNavigation { get; set; }

    public virtual DmKip? IdkipNavigation { get; set; }

    public virtual DmSinhVien? IdsinhVienNavigation { get; set; }

    public virtual DmNhanVien? IdttNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlHopDongCt> QlHopDongCts { get; set; } = new List<QlHopDongCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCts { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlScanHd> QlScanHds { get; set; } = new List<QlScanHd>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();
}
