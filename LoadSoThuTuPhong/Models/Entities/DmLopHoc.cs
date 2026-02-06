using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmLopHoc
{
    public long Id { get; set; }

    public long? IdnienKhoa { get; set; }

    public string? MaLopHoc { get; set; }

    public string? TenLopHoc { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmSinhVien> DmSinhViens { get; set; } = new List<DmSinhVien>();

    public virtual DmNienKhoa? IdnienKhoaNavigation { get; set; }
}
