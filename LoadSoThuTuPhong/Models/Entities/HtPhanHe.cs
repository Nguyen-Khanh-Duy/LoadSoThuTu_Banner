using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtPhanHe
{
    public long Id { get; set; }

    public string? SoThuTu { get; set; }

    public long? Cot { get; set; }

    public string? TenPhanHe { get; set; }

    public virtual ICollection<HtChucNang> HtChucNangs { get; set; } = new List<HtChucNang>();
}
