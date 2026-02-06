using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmIcd
{
    public long Id { get; set; }

    public string? MaBenh { get; set; }

    public string? TenBenh { get; set; }

    public string? NhomBenh { get; set; }

    public string? ManTinh { get; set; }

    public string? BenhCua { get; set; }

    public string? ThuongGap { get; set; }

    public string? BenhNam { get; set; }

    public string? KhongBh { get; set; }

    public string? NgoaiDs { get; set; }

    public string? ChuyenKhoa { get; set; }

    public string? MoTa { get; set; }

    public string? HieuLuc { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlChanDoanCt> QlChanDoanCts { get; set; } = new List<QlChanDoanCt>();
}
