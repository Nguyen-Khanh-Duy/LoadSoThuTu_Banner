using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmCaLamViec
{
    public long Id { get; set; }

    public string? MaCa { get; set; }

    public string? TenCa { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmThoiGianHen> DmThoiGianHens { get; set; } = new List<DmThoiGianHen>();

    public virtual ICollection<HtLichNghi> HtLichNghis { get; set; } = new List<HtLichNghi>();
}
