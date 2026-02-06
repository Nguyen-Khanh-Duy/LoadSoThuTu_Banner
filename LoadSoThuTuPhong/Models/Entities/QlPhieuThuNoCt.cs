using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuThuNoCt
{
    public long Id { get; set; }

    public long? Idptn { get; set; }

    public long? Idpxk { get; set; }

    public double? SoTien { get; set; }

    public virtual QlPhieuThuNo? IdptnNavigation { get; set; }

    public virtual HhPhieuXuatKho? IdpxkNavigation { get; set; }
}
