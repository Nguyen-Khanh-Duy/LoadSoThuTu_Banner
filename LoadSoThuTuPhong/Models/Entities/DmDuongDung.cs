using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmDuongDung
{
    public long Id { get; set; }

    public string? MaDuongDung { get; set; }

    public string? TenDuongDung { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<HhDmHangHoa> HhDmHangHoas { get; set; } = new List<HhDmHangHoa>();
}
