using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmVaiTro
{
    public long Id { get; set; }

    public string? MaVaiTro { get; set; }

    public string? TenVaiTro { get; set; }

    public bool? SinhVien { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<HtPhanQuyen> HtPhanQuyens { get; set; } = new List<HtPhanQuyen>();

    public virtual ICollection<HtQuyenVaiTro> HtQuyenVaiTros { get; set; } = new List<HtQuyenVaiTro>();
}
