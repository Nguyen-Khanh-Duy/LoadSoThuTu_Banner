using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDeNghiCapHangCt
{
    public long Id { get; set; }

    public long? Idphieu { get; set; }

    public long? Idhh { get; set; }

    public long? Iddvt { get; set; }

    public double? SldeNghi { get; set; }

    public double? SldaCap { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual HhDmDonViTinh? IddvtNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }

    public virtual QlPhieuDeNghiCapHang? IdphieuNavigation { get; set; }
}
