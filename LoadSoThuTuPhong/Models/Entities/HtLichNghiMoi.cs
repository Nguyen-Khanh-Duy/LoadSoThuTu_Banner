using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtLichNghiMoi
{
    public long Id { get; set; }

    public DateTime? Ngay { get; set; }

    public long? IdNv { get; set; }

    public long? IdCa { get; set; }

    public long? IdThoiGian { get; set; }

    public int? Thu { get; set; }

    public bool? ToanVien { get; set; }

    public virtual DmThoiGianHen? IdThoiGianNavigation { get; set; }
}
