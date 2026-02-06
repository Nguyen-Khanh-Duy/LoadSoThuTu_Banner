using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmRang
{
    public long Id { get; set; }

    public string? Ten { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmRangCt> DmRangCts { get; set; } = new List<DmRangCt>();
}
