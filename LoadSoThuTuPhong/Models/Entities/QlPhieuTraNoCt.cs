using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuTraNoCt
{
    public long Id { get; set; }

    public long? Idptn { get; set; }

    public long? Idpnk { get; set; }

    public double? SoTien { get; set; }

    public virtual HhPhieuNhapKho? IdpnkNavigation { get; set; }

    public virtual QlPhieuTraNo? IdptnNavigation { get; set; }
}
