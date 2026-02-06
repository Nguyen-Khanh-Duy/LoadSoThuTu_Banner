using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlHoaDonCt
{
    public long Id { get; set; }

    public long? IdhoaDon { get; set; }

    public long? IdkhdieuTriCt { get; set; }

    public double? Sl { get; set; }

    public double? DonGia { get; set; }

    public double? Vat { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdphieuThuCt { get; set; }

    public virtual QlHoaDon? IdhoaDonNavigation { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhdieuTriCtNavigation { get; set; }

    public virtual QlThuTienDieuTriCt? IdphieuThuCtNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
