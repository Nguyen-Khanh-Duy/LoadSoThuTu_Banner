using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TempQuyTrinhDieuTriCt
{
    public long Id { get; set; }

    public long? Idqt { get; set; }

    public string? ThuTu { get; set; }

    public string? ThucHien { get; set; }

    public virtual TempQuyTrinhDieuTri? IdqtNavigation { get; set; }

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();
}
