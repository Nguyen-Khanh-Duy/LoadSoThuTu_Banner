using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNganKe
{
    public long Id { get; set; }

    public string? NganKe { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlBenhAn> QlBenhAns { get; set; } = new List<QlBenhAn>();
}
