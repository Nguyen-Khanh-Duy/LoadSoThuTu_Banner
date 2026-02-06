using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuNhapCcdc
{
    public long Id { get; set; }

    public string? SoPhieuNhap { get; set; }

    public DateTime? NgayGioNhap { get; set; }

    public long? IdnhaCungCap { get; set; }

    public string? SoHoaDon { get; set; }

    public DateOnly? NgayHoaDon { get; set; }

    public string? KyHieuHoaDon { get; set; }

    public long? IdnhanVienNhap { get; set; }

    public string? GhiChuPhieuNhap { get; set; }

    public long? IdnhanVienSua { get; set; }

    public long? Idcn { get; set; }

    public virtual ICollection<HhPhieuNhapCcdcCt> HhPhieuNhapCcdcCts { get; set; } = new List<HhPhieuNhapCcdcCt>();

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual HhDmNhaCungCap? IdnhaCungCapNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNhapNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienSuaNavigation { get; set; }
}
