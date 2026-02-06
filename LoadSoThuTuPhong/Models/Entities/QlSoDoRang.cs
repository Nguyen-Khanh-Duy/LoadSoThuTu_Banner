using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlSoDoRang
{
    public long Id { get; set; }

    public long? IdphieuKham { get; set; }

    public string? MaHinh { get; set; }

    public int? ITop { get; set; }

    public int? ILeft { get; set; }

    public int? IHeight { get; set; }

    public int? IWidth { get; set; }
}
