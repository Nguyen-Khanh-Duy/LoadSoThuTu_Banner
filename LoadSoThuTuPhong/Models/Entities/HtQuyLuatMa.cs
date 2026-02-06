using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtQuyLuatMa
{
    public long Id { get; set; }

    public string? TenBang { get; set; }

    public string? KyTuDau { get; set; }

    public int? DoDaiMa { get; set; }

    public virtual ICollection<HtQuanLyMa> HtQuanLyMas { get; set; } = new List<HtQuanLyMa>();
}
