using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNuocSanXuat
{
    public long Id { get; set; }

    public string MaNsx { get; set; } = null!;

    public string? TenNsx { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<HhDmHangHoa> HhDmHangHoas { get; set; } = new List<HhDmHangHoa>();
}
