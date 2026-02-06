using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDeNghiCapHang
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public long? IdchiNhanhDeNghi { get; set; }

    public DateTime? ThoiGianDeNghi { get; set; }

    public long? IdnhanVienDeNghi { get; set; }

    public long? IdnhanVien { get; set; }

    public string? GhiChu { get; set; }

    public bool? Duyet { get; set; }

    public long? IdCnnhanDeNghi { get; set; }

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();

    public virtual DmChiNhanh? IdCnnhanDeNghiNavigation { get; set; }

    public virtual DmChiNhanh? IdchiNhanhDeNghiNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienDeNghiNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }

    public virtual ICollection<QlPhieuDeNghiCapHangCt> QlPhieuDeNghiCapHangCts { get; set; } = new List<QlPhieuDeNghiCapHangCt>();
}
