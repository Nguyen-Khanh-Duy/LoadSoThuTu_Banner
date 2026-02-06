using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNgheNghiep
{
    public long Id { get; set; }

    public string? Cap1 { get; set; }

    public string? Cap2 { get; set; }

    public string? Cap3 { get; set; }

    public string? Cap4 { get; set; }

    public string? MaNgheNghiep { get; set; }

    public string? TenNgheNghiep { get; set; }

    public int? ThongTu { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; } = new List<DmBenhNhanDuBi>();

    public virtual ICollection<DmBenhNhan> DmBenhNhans { get; set; } = new List<DmBenhNhan>();
}
