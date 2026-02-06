using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNhomDichVuKyThuat
{
    public long Id { get; set; }

    public string? MaNhomDichVu { get; set; }

    public string? TenNhomDichVu { get; set; }

    public bool? DieuTri { get; set; }

    public bool? ThamMy { get; set; }

    public bool? KyThuatThuong { get; set; }

    public bool? KyThuatCao { get; set; }

    public bool? Active { get; set; }

    public double? Vat { get; set; }

    public bool? ChinhNha { get; set; }

    public bool? Implant { get; set; }

    public string? MaChiNhanh { get; set; }

    public virtual ICollection<DmDichVuKyThuat> DmDichVuKyThuats { get; set; } = new List<DmDichVuKyThuat>();

    public virtual ICollection<DmPhucHinh> DmPhucHinhs { get; set; } = new List<DmPhucHinh>();

    public virtual ICollection<DmTiLeLuong> DmTiLeLuongs { get; set; } = new List<DmTiLeLuong>();
}
