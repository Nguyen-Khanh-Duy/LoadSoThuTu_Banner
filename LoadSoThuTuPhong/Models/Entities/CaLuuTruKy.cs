using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CaLuuTruKy
{
    public long Id { get; set; }

    public string? MaCongVan { get; set; }

    public long? IdchiNhanh { get; set; }

    public long? IdbenhNhan { get; set; }

    public long? IdvaoVien { get; set; }

    public DateTime? NgayKy { get; set; }

    public string? Url { get; set; }

    public long? IdtrangThaiKy { get; set; }

    public long? Idaccount { get; set; }

    public long? IdcongVan { get; set; }

    public DateTime? TuNgay { get; set; }

    public DateTime? DenNgay { get; set; }

    public string? LichSu { get; set; }

    public virtual DmBenhNhan? IdbenhNhanNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
