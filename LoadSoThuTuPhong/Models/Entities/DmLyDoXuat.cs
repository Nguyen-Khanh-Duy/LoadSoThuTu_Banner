using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmLyDoXuat
{
    public long Id { get; set; }

    public string? TenLyDo { get; set; }

    public virtual ICollection<HhPhieuXuatThanhLy> HhPhieuXuatThanhLies { get; set; } = new List<HhPhieuXuatThanhLy>();
}
