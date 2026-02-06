using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdNgay
{
    public int Id { get; set; }

    public DateOnly? Ngay { get; set; }
}
