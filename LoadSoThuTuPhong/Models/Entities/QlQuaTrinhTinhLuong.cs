using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlQuaTrinhTinhLuong
{
    public long Id { get; set; }

    public long? Idkhdtct { get; set; }

    public long? IdbacSi { get; set; }

    public long? IdtroThu { get; set; }

    public double? TyLe { get; set; }

    public long? Idkip { get; set; }

    public virtual DmNhanVien? IdbacSiNavigation { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhdtctNavigation { get; set; }

    public virtual DmKip? IdkipNavigation { get; set; }

    public virtual DmNhanVien? IdtroThuNavigation { get; set; }
}
