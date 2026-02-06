using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmKip
{
    public long Id { get; set; }

    public string? TenKip { get; set; }

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();

    public virtual ICollection<QlHoaDon> QlHoaDons { get; set; } = new List<QlHoaDon>();

    public virtual ICollection<QlKeHoachDieuTri> QlKeHoachDieuTris { get; set; } = new List<QlKeHoachDieuTri>();

    public virtual ICollection<QlQuaTrinhTinhLuong> QlQuaTrinhTinhLuongs { get; set; } = new List<QlQuaTrinhTinhLuong>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();
}
