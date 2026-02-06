using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNoiSuDung
{
    public long Id { get; set; }

    public long? Idcn { get; set; }

    public string? MaNoi { get; set; }

    public string? TenNoi { get; set; }

    public bool? Active { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }
}
