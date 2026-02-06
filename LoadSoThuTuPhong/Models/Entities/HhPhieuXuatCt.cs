using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuXuatCt
{
    public long Id { get; set; }

    public long? Idpx { get; set; }

    public long? Idhh { get; set; }

    public long? Iddvt { get; set; }

    public double? Slqd { get; set; }

    public double? Sl { get; set; }

    public double? DonGia { get; set; }

    public long? Idctpn { get; set; }

    public double? Cktm { get; set; }

    public double? Thue { get; set; }

    public string? GhiChu { get; set; }

    public long? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public long? Idkhdtct { get; set; }

    public long? IdnoiSuDung { get; set; }

    public long? IdphieuDeNghiCt { get; set; }

    public virtual HhPhieuNhapCt? IdctpnNavigation { get; set; }

    public virtual HhDmDonViTinh? IddvtNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhdtctNavigation { get; set; }

    public virtual HhDmNoiSuDung? IdnoiSuDungNavigation { get; set; }

    public virtual QlPhieuDeNghiCapHangCt? IdphieuDeNghiCtNavigation { get; set; }

    public virtual HhPhieuXuatKho? IdpxNavigation { get; set; }
}
