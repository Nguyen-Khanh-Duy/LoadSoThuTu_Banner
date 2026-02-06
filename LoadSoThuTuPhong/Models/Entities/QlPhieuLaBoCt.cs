using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuLaBoCt
{
    public long Id { get; set; }

    public long? Idplb { get; set; }

    public long? Idkhct { get; set; }

    public long? Idph { get; set; }

    public double? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhctNavigation { get; set; }

    public virtual DmPhucHinh? IdphNavigation { get; set; }

    public virtual QlPhieuLaBo? IdplbNavigation { get; set; }
}
