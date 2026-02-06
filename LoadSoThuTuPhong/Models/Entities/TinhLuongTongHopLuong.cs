using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TinhLuongTongHopLuong
{
    public long Id { get; set; }

    public long? Idvv { get; set; }

    public long? Idbn { get; set; }

    public long? Idnv { get; set; }

    public long? IdcongViec { get; set; }

    public DateTime? Ngay { get; set; }

    public double? SoLuong { get; set; }

    public double? SoTien { get; set; }

    public double? TyLe { get; set; }

    public double? ChiPhi { get; set; }

    public bool? Chinh { get; set; }

    public bool? Phu { get; set; }

    public bool? PhuImplant { get; set; }

    public bool? HoaHongMarketting { get; set; }

    public virtual DmBenhNhan? IdbnNavigation { get; set; }

    public virtual TinhLuongCongViecHoTro? IdcongViecNavigation { get; set; }

    public virtual DmNhanVien? IdnvNavigation { get; set; }

    public virtual QlVaoVien? IdvvNavigation { get; set; }
}
