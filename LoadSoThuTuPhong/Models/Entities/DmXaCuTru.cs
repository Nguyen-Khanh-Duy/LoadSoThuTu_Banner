using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmXaCuTru
{
    public long Id { get; set; }

    public string? MaXa { get; set; }

    public string? TenXa { get; set; }

    public long? Idtinh { get; set; }

    public long? Idquan { get; set; }

    public int? ThongTu { get; set; }

    public bool? Cq2c { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; } = new List<DmBenhNhanDuBi>();

    public virtual ICollection<DmBenhNhan> DmBenhNhans { get; set; } = new List<DmBenhNhan>();

    public virtual DmQuanCuTru? IdquanNavigation { get; set; }
}
