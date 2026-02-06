using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTinhCuTru
{
    public long Id { get; set; }

    public string? MaTinh { get; set; }

    public string? TenTinh { get; set; }

    public bool? Vung2 { get; set; }

    public int? ThongTu { get; set; }

    public bool? Cq2c { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; } = new List<DmBenhNhanDuBi>();

    public virtual ICollection<DmBenhNhan> DmBenhNhans { get; set; } = new List<DmBenhNhan>();

    public virtual ICollection<DmQuanCuTru> DmQuanCuTrus { get; set; } = new List<DmQuanCuTru>();
}
