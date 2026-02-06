using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmKetQuaDieuTri
{
    public long Id { get; set; }

    public string? KetQuaDieuTri { get; set; }

    public bool? HoanTat { get; set; }

    public bool? KhongHoanTat { get; set; }

    public bool? ChoThanhToan { get; set; }

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCts { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();
}
