using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmDichVuKyThuatGium
{
    public long Id { get; set; }

    public long? Iddvkt { get; set; }

    public string? MoTa { get; set; }

    public double? Gia { get; set; }

    public long? Idkhu { get; set; }

    public virtual DmDichVuKyThuat? IddvktNavigation { get; set; }

    public virtual DmChiNhanh? IdkhuNavigation { get; set; }
}
