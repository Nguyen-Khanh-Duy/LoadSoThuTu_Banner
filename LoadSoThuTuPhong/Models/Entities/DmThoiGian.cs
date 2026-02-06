using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmThoiGian
{
    public long Id { get; set; }

    public string? TenThoiGian { get; set; }

    public int? SoNgay { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmDichVuKyThuat> DmDichVuKyThuatIdthoiGianBaoHanhNavigations { get; set; } = new List<DmDichVuKyThuat>();

    public virtual ICollection<DmDichVuKyThuat> DmDichVuKyThuatIdthoiGianChamSocDinhKyNavigations { get; set; } = new List<DmDichVuKyThuat>();

    public virtual ICollection<DmDichVuKyThuat> DmDichVuKyThuatIdthoiGianChamSocSauDieuTriNavigations { get; set; } = new List<DmDichVuKyThuat>();

    public virtual ICollection<DmPhucHinh> DmPhucHinhs { get; set; } = new List<DmPhucHinh>();
}
