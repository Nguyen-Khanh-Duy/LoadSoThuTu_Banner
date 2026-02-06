using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlThuTienDieuTriDatCoc
{
    public long Id { get; set; }

    public long? IdthuTienDt { get; set; }

    public long? IdphieuDatCoc { get; set; }

    public double? SoTien { get; set; }

    public virtual QlPhieuDatCoc? IdphieuDatCocNavigation { get; set; }

    public virtual QlThuTienDieuTri? IdthuTienDtNavigation { get; set; }
}
