using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlThuTienDieuTriCt
{
    public long Id { get; set; }

    public long IdthuTienDt { get; set; }

    public long? IdkeHoachDtct { get; set; }

    public double? SoTien { get; set; }

    public long? IdbacSi { get; set; }

    public long? IdtroThu { get; set; }

    public double? Tile { get; set; }

    public DateTime? NgayHoanTien { get; set; }

    public double? SoTienHoan { get; set; }

    public long? IdnguoiHoanTien { get; set; }

    public string? GhiChuHoanTien { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkeHoachDtctNavigation { get; set; }

    public virtual QlThuTienDieuTri IdthuTienDtNavigation { get; set; } = null!;

    public virtual ICollection<QlHoaDonCt> QlHoaDonCts { get; set; } = new List<QlHoaDonCt>();
}
