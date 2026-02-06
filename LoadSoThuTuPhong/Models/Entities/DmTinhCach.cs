using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTinhCach
{
    public long Id { get; set; }

    public string TinhCach { get; set; } = null!;

    public bool? Active { get; set; }

    public virtual ICollection<QlVaoVien> QlVaoViens { get; set; } = new List<QlVaoVien>();
}
