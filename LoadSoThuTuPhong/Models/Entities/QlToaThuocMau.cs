using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlToaThuocMau
{
    public long Id { get; set; }

    public string? MaToaMau { get; set; }

    public string? TenToaMau { get; set; }

    public double? SoNgay { get; set; }

    public string? LoaiToa { get; set; }

    public string? TrieuChung { get; set; }

    public virtual ICollection<QlToaThuocMauCd> QlToaThuocMauCds { get; set; } = new List<QlToaThuocMauCd>();

    public virtual ICollection<QlToaThuocMauCt> QlToaThuocMauCts { get; set; } = new List<QlToaThuocMauCt>();
}
