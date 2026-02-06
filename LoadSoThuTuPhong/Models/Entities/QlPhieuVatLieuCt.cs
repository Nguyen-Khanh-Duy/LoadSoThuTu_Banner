using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuVatLieuCt
{
    public long Id { get; set; }

    public long? IdphieuVl { get; set; }

    public long? Idkhct { get; set; }

    public long? Idhh { get; set; }

    public double? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhctNavigation { get; set; }

    public virtual QlPhieuVatLieu? IdphieuVlNavigation { get; set; }
}
