using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuNhapKho
{
    public long Id { get; set; }

    public string? SoPn { get; set; }

    public bool? NhapNoiBo { get; set; }

    public long? IdphieuXuatNoi { get; set; }

    public long? Idcnxuat { get; set; }

    public long? Idncc { get; set; }

    public long? Idcn { get; set; }

    public long? Idnv { get; set; }

    public string? SoHd { get; set; }

    public DateOnly? NgayHd { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public long? IdnguonNhapXuat { get; set; }

    public long? IdnoiSuDung { get; set; }

    public bool? DaThanhToan { get; set; }

    public virtual ICollection<HhPhieuNhapCt> HhPhieuNhapCts { get; set; } = new List<HhPhieuNhapCt>();

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmChiNhanh? IdcnxuatNavigation { get; set; }

    public virtual HhDmNhaCungCap? IdnccNavigation { get; set; }

    public virtual HhDmNguonNhapXuat? IdnguonNhapXuatNavigation { get; set; }

    public virtual HhDmNoiSuDung? IdnoiSuDungNavigation { get; set; }

    public virtual DmNhanVien? IdnvNavigation { get; set; }

    public virtual HhPhieuXuatKho? IdphieuXuatNoiNavigation { get; set; }

    public virtual ICollection<QlPhieuTraNoCt> QlPhieuTraNoCts { get; set; } = new List<QlPhieuTraNoCt>();
}
