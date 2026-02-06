using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class ApiZlMaLoi
{
    public long Id { get; set; }

    public int? MaLoi { get; set; }

    public string? MoTaLoi { get; set; }

    public string? ThongTinLoi { get; set; }
}
