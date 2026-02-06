using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhTinhGiaXuat
{
    public long Id { get; set; }

    public string MaCach { get; set; } = null!;

    public string TenCach { get; set; } = null!;

    public bool GiaTri { get; set; }
}
