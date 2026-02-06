using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmMoiLienHe
{
    public long Id { get; set; }

    public string? TenMoiLienHe { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmBenhNhan> DmBenhNhans { get; set; } = new List<DmBenhNhan>();
}
