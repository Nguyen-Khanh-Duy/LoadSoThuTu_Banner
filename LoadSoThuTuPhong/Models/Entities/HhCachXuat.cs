using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhCachXuat
{
    public long Id { get; set; }

    public bool? TheoHsd { get; set; }

    public bool? TheoTgnhap { get; set; }
}
