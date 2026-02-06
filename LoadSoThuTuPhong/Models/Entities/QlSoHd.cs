using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlSoHd
{
    public long Id { get; set; }

    public string? KyHieuHd { get; set; }

    public string? LoaiHd { get; set; }

    public string? Seri { get; set; }

    public string? Quyen { get; set; }

    public int? SoBatDau { get; set; }

    public int? SoKetThuc { get; set; }

    public int? SoHienTai { get; set; }

    public int? DoDai { get; set; }

    public long? IdNhanVien { get; set; }

    public bool? Active { get; set; }

    public bool? DaXuat { get; set; }

    public long? IdKhu { get; set; }

    public virtual DmNhanVien? IdNhanVienNavigation { get; set; }
}
