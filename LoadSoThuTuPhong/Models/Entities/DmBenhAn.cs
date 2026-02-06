using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBenhAn
{
    public long Id { get; set; }

    public string? MaBenhAn { get; set; }

    public string? TenBenhAn { get; set; }

    public string? ViewName { get; set; }

    public virtual ICollection<DmMauBenhAn> DmMauBenhAns { get; set; } = new List<DmMauBenhAn>();

    public virtual ICollection<QlBenhAn> QlBenhAns { get; set; } = new List<QlBenhAn>();
}
