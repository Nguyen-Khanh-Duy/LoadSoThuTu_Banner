using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTemplate
{
    public long Id { get; set; }

    public string? MauTemplate { get; set; }

    public virtual ICollection<CskhLoaiCskh> CskhLoaiCskhs { get; set; } = new List<CskhLoaiCskh>();
}
