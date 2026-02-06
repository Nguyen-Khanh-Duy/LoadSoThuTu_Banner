using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class KsCauTraLoi
{
    public long Id { get; set; }

    public string? CauTraLoi { get; set; }

    public bool? CheckBox { get; set; }

    public bool? Text { get; set; }

    public virtual ICollection<KsCauHoiTraLoi> KsCauHoiTraLois { get; set; } = new List<KsCauHoiTraLoi>();

    public virtual ICollection<KsKetQuaK> KsKetQuaKs { get; set; } = new List<KsKetQuaK>();
}
