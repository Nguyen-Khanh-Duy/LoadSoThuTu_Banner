using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmRangCt
{
    public long Id { get; set; }

    public long? IdvaoVien { get; set; }

    public long? Idrang { get; set; }

    public long? IdhienTrangRang { get; set; }

    public bool? Rang { get; set; }

    public string? Anh { get; set; }

    public string? MoTaKhac { get; set; }

    public bool? MatTrong { get; set; }

    public bool? MatNgoai { get; set; }

    public bool? MatNhai { get; set; }

    public bool? MatXa { get; set; }

    public bool? MatGan { get; set; }

    public string? GhiChu { get; set; }

    public string? NiengRang { get; set; }

    public virtual DmHienTrangRang? IdhienTrangRangNavigation { get; set; }

    public virtual DmRang? IdrangNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
