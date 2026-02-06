using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDeNghiCt
{
    public long Id { get; set; }

    public long? IddeNghi { get; set; }

    public long? Idkhct { get; set; }

    public double? SoTien { get; set; }

    public virtual QlPhieuDeNghi? IddeNghiNavigation { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhctNavigation { get; set; }
}
