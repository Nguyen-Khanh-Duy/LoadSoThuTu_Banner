using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuNhapCt
{
    public long Id { get; set; }

    public long? Idpn { get; set; }

    public long? Idhh { get; set; }

    public long? Iddvtnhap { get; set; }

    public double? Slqd { get; set; }

    public double Sl { get; set; }

    public double DonGia { get; set; }

    public double? ThanhTien { get; set; }

    public double? Cktm { get; set; }

    public double? Thue { get; set; }

    public string? SoLo { get; set; }

    public DateTime? Nsx { get; set; }

    public DateTime? Hsd { get; set; }

    public string? GhiChu { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual ICollection<HhHangTonKho> HhHangTonKhos { get; set; } = new List<HhHangTonKho>();

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual HhDmDonViTinh? IddvtnhapNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }

    public virtual HhPhieuNhapKho? IdpnNavigation { get; set; }
}
