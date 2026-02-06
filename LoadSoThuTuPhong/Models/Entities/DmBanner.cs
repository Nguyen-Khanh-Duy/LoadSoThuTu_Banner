using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBanner
{
    public long Id { get; set; }

    public string TieuDe { get; set; } = null!;

    public string? HinhAnh { get; set; }

    public string? NoiDung { get; set; }

    public string ViTri { get; set; } = null!;

    public int ThuTu { get; set; }

    public bool HoatDong { get; set; }

    public string? DuongDan { get; set; }

    public DateTime NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public long? IdchiNhanh { get; set; }

    public virtual DmChiNhanh? IdchiNhanhNavigation { get; set; }
}
