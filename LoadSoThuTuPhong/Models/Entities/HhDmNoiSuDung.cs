using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNoiSuDung
{
    public long Id { get; set; }

    public string? TenNoiSuDung { get; set; }

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhos { get; set; } = new List<HhPhieuNhapKho>();

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();
}
