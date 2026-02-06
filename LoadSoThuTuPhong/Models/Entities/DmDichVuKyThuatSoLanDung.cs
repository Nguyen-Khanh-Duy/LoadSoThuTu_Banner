using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmDichVuKyThuatSoLanDung
{
    public long Id { get; set; }

    public long? Iddvkt { get; set; }

    public long? Idkhu { get; set; }

    public int? SoLanDung { get; set; }

    public virtual DmDichVuKyThuat? IddvktNavigation { get; set; }

    public virtual DmChiNhanh? IdkhuNavigation { get; set; }
}
