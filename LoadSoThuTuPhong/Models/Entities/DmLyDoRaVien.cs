using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmLyDoRaVien
{
    public long Id { get; set; }

    public string LyDoRaVien { get; set; } = null!;

    public bool? HoanTat { get; set; }

    public bool? BoDieuTri { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlVaoVien> QlVaoViens { get; set; } = new List<QlVaoVien>();
}
