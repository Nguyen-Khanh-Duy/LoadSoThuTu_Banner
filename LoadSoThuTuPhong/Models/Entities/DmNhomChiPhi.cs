using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNhomChiPhi
{
    public long Id { get; set; }

    public int? Stt { get; set; }

    public string? Ma { get; set; }

    public string? TenNhomChiPhi { get; set; }

    public string? KyHieu { get; set; }

    public double? Heso { get; set; }

    public virtual ICollection<DmDichVuKyThuat> DmDichVuKyThuats { get; set; } = new List<DmDichVuKyThuat>();
}
