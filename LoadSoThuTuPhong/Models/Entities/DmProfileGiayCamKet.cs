using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmProfileGiayCamKet
{
    public long Id { get; set; }

    public string? TenMau { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }
}
