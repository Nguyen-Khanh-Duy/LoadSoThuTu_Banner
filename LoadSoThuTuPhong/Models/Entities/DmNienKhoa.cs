using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNienKhoa
{
    public long Id { get; set; }

    public string? MaNienKhoa { get; set; }

    public string? NienKhoa { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmLopHoc> DmLopHocs { get; set; } = new List<DmLopHoc>();
}
