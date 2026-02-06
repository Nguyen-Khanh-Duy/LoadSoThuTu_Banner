using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CcNoiDungVietTat
{
    public long Id { get; set; }

    public long? IdviTri { get; set; }

    public long? IdnhanVien { get; set; }

    public string? VietTat { get; set; }

    public string? NoiDung { get; set; }
}
