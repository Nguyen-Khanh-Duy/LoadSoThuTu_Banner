using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlChanDoan
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdbenhNhan { get; set; }

    public long? IdbacSiThucHien { get; set; }

    public long? IdnhanVienThucHien { get; set; }

    public string? TrieuChung { get; set; }

    public string? MaBenhBanDau { get; set; }

    public string? TenBenhBanDau { get; set; }

    public string? MaVaTenBenhVao { get; set; }

    public string? MaBenhChinh { get; set; }

    public string? TenBenhChinh { get; set; }

    public string? MaBenhKhac { get; set; }

    public string? TenBenhKhac { get; set; }

    public string? MaVaTenBenh { get; set; }

    public virtual DmNhanVien? IdbacSiThucHienNavigation { get; set; }

    public virtual DmBenhNhan? IdbenhNhanNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienThucHienNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlChanDoanCt> QlChanDoanCts { get; set; } = new List<QlChanDoanCt>();
}
