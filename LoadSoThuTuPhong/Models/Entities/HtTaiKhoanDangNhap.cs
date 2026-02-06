using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtTaiKhoanDangNhap
{
    public long Id { get; set; }

    public string? TaiKhoan { get; set; }

    public string? MatKhau { get; set; }

    public virtual ICollection<DmNhanVien> DmNhanViens { get; set; } = new List<DmNhanVien>();
}
