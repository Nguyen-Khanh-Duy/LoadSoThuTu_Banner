using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmDoiTac
{
    public long Id { get; set; }

    public string? MaDoiTac { get; set; }

    public string? TenDoiTac { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlChiDinh> QlChiDinhs { get; set; } = new List<QlChiDinh>();
}
