using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDuTruCt
{
    public long Id { get; set; }

    public long? Idphieu { get; set; }

    public long? Idhh { get; set; }

    public long? Iddvt { get; set; }

    public double? SlduTru { get; set; }

    public double? SldaCap { get; set; }

    public string? GhiChu { get; set; }

    public virtual HhDmDonViTinh? IddvtNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }

    public virtual QlPhieuDuTru? IdphieuNavigation { get; set; }
}
