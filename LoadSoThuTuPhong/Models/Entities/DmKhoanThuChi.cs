using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmKhoanThuChi
{
    public long Id { get; set; }

    public string? KhoanThuChi { get; set; }

    public bool? Thu { get; set; }

    public bool? Chi { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<QlPhieuChiCt> QlPhieuChiCts { get; set; } = new List<QlPhieuChiCt>();

    public virtual ICollection<QlPhieuThuCt> QlPhieuThuCts { get; set; } = new List<QlPhieuThuCt>();
}
