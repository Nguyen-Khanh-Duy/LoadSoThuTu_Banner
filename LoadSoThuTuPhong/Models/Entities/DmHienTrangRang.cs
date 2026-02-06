using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmHienTrangRang
{
    public long Id { get; set; }

    public string? MoTa { get; set; }

    public string? Logo { get; set; }

    public bool? ThamMy { get; set; }

    public bool? Benh { get; set; }

    public bool? HienTrang { get; set; }

    public bool? PhucHinh { get; set; }

    public int? Level { get; set; }

    public string? RangBaChan { get; set; }

    public string? RangMotChan { get; set; }

    public bool? Active { get; set; }

    public int? StthienTrang { get; set; }

    public int? StthienThi { get; set; }

    public bool? NguyenHam { get; set; }

    public bool? MatRang { get; set; }

    public virtual ICollection<DmRangCt> DmRangCts { get; set; } = new List<DmRangCt>();
}
