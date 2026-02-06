using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlHopDongCt
{
    public long Id { get; set; }

    public long? IdkeHoachDt { get; set; }

    public DateOnly? NgayHen { get; set; }

    public int? LanHen { get; set; }

    public double? SoTien { get; set; }

    public string? NoiDung { get; set; }

    public bool? DaThu { get; set; }

    public virtual QlKeHoachDieuTri? IdkeHoachDtNavigation { get; set; }
}
