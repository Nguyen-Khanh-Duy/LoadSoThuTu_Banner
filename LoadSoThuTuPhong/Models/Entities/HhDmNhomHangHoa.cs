using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNhomHangHoa
{
    public long Id { get; set; }

    public string MaNhh { get; set; } = null!;

    public string? TenNhh { get; set; }

    public bool? HhdemDuoc { get; set; }

    public bool? HhkhongDemDuoc { get; set; }

    public bool? Thuoc { get; set; }

    public bool? Vpp { get; set; }

    public bool? Ccdc { get; set; }

    public bool? TscoDinh { get; set; }

    public long? IdnhomDvkt { get; set; }

    public bool? CongCuDungCu { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<HhDmHangHoa> HhDmHangHoas { get; set; } = new List<HhDmHangHoa>();
}
