using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtQuanLyMa
{
    public long Id { get; set; }

    public string? MaQuay { get; set; }

    public long? IdquyLuatMa { get; set; }

    public DateOnly? Ngay { get; set; }

    public int? SoThuTu { get; set; }

    public long? Idcn { get; set; }

    public virtual HtQuyLuatMa? IdquyLuatMaNavigation { get; set; }
}
