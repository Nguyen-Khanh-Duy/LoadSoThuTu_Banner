using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTinhTrang
{
    public long Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<DmBoDungCuCt> DmBoDungCuCts { get; set; } = new List<DmBoDungCuCt>();
}
