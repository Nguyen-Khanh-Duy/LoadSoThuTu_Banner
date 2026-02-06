using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNganHang
{
    public long Id { get; set; }

    public string? MaNganHang { get; set; }

    public string? TenNgan { get; set; }

    public string? TenNganHang { get; set; }

    public string? Bin { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DmChiNhanh> DmChiNhanhs { get; set; } = new List<DmChiNhanh>();

    public virtual ICollection<DmNganHangDoanhNghiep> DmNganHangDoanhNghieps { get; set; } = new List<DmNganHangDoanhNghiep>();

    public virtual ICollection<DmNhanVien> DmNhanViens { get; set; } = new List<DmNhanVien>();

    public virtual ICollection<HhDmNhaCungCap> HhDmNhaCungCaps { get; set; } = new List<HhDmNhaCungCap>();
}
