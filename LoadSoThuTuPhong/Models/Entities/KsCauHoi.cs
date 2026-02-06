using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class KsCauHoi
{
    public long Id { get; set; }

    public string? CauHoi { get; set; }

    public bool? MotCauTraLoi { get; set; }

    public bool? BatBuoc { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<KsCauHoiTraLoi> KsCauHoiTraLois { get; set; } = new List<KsCauHoiTraLoi>();

    public virtual ICollection<KsKetQuaK> KsKetQuaKs { get; set; } = new List<KsKetQuaK>();
}
