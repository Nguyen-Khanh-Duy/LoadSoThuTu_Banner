using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmMarKetting
{
    public long Id { get; set; }

    public string? MaMarKetting { get; set; }

    public string? TenMarKetting { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlVaoVien> QlVaoViens { get; set; } = new List<QlVaoVien>();
}
