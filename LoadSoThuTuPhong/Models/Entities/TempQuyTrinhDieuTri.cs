using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TempQuyTrinhDieuTri
{
    public long Id { get; set; }

    public string? TenQuyTrinh { get; set; }

    public string? HuongDan { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlTuongQuanDvktQt> QlTuongQuanDvktQts { get; set; } = new List<QlTuongQuanDvktQt>();

    public virtual ICollection<TempQuyTrinhDieuTriCt> TempQuyTrinhDieuTriCts { get; set; } = new List<TempQuyTrinhDieuTriCt>();
}
