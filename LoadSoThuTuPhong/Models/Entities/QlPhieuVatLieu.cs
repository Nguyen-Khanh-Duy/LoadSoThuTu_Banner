using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuVatLieu
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayDeNghi { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdNhanVienTao { get; set; }

    public string? GhiChu { get; set; }

    public long? Idcn { get; set; }

    public bool? XuatBan { get; set; }

    public virtual DmNhanVien? IdNhanVienTaoNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlPhieuVatLieuCt> QlPhieuVatLieuCts { get; set; } = new List<QlPhieuVatLieuCt>();
}
