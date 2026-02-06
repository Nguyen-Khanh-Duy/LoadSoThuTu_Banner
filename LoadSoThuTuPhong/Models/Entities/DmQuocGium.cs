using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmQuocGium
{
    public long Id { get; set; }

    public string? MaQuocGia { get; set; }

    public string? TenQuocGia { get; set; }

    public int? ThongTu { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; } = new List<DmBenhNhanDuBi>();

    public virtual ICollection<DmBenhNhan> DmBenhNhans { get; set; } = new List<DmBenhNhan>();
}
