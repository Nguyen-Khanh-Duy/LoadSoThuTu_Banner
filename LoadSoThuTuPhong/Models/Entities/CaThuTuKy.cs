using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CaThuTuKy
{
    public long? Id { get; set; }

    public string? MaLoai { get; set; }

    public int? Stt { get; set; }

    public string? Url { get; set; }
}
