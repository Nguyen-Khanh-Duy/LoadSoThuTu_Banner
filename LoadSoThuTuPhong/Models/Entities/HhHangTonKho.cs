using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhHangTonKho
{
    public long Id { get; set; }

    public long? Idpn { get; set; }

    public long? Idncc { get; set; }

    public long? Idcnxuat { get; set; }

    public long? Idctpn { get; set; }

    public DateTime? NgayNhap { get; set; }

    public long? Idhh { get; set; }

    public long? Iddvtnhap { get; set; }

    public long? Iddvtton { get; set; }

    public double? Slcon { get; set; }

    public double? GiaNhap { get; set; }

    public string? SoLo { get; set; }

    public double? Thue { get; set; }

    public double? Cktm { get; set; }

    public DateTime? Hsd { get; set; }

    public DateOnly? Nsx { get; set; }

    public string? GhiChu { get; set; }

    public long? Idcn { get; set; }

    public virtual HhPhieuNhapCt? IdctpnNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }
}
