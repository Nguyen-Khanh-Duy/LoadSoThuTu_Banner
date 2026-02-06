using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CskhTemplateCt
{
    public long Id { get; set; }

    public long? IdloaiCskh { get; set; }

    public string? ThamSoZalo { get; set; }

    public long? IddinhNghiaThamSo { get; set; }

    public virtual CskhDinhNghiaThamSo? IddinhNghiaThamSoNavigation { get; set; }

    public virtual CskhLoaiCskh? IdloaiCskhNavigation { get; set; }
}
