using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmThoiGianHen
{
    public long Id { get; set; }

    public TimeOnly ThoiGianBatDau { get; set; }

    public TimeOnly ThoiGianKetThuc { get; set; }

    public bool Active { get; set; }

    public long? IdCa { get; set; }

    public virtual ICollection<HtLichNghiMoi> HtLichNghiMois { get; set; } = new List<HtLichNghiMoi>();

    public virtual DmCaLamViec? IdCaNavigation { get; set; }

    public virtual ICollection<QlHen> QlHens { get; set; } = new List<QlHen>();
}
