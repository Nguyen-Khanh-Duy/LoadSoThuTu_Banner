using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNguonNhapXuat
{
    public long Id { get; set; }

    public string? MaNguon { get; set; }

    public string? TenNguon { get; set; }

    public bool? Nhap { get; set; }

    public bool? Xuat { get; set; }

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhos { get; set; } = new List<HhPhieuNhapKho>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();
}
