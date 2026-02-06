using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuXuatThanhLyCt
{
    public long Id { get; set; }

    public long? IdphieuXuatKho { get; set; }

    public long? IdhangHoa { get; set; }

    public long? IddonViXuat { get; set; }

    public long? IdphieuNhapCt { get; set; }

    public double? SoLuongXuat { get; set; }

    public double? DonGiaXuat { get; set; }

    public string? GhiChuHangXuat { get; set; }

    public virtual HhDmDonViTinh? IddonViXuatNavigation { get; set; }

    public virtual HhDmHangHoa? IdhangHoaNavigation { get; set; }

    public virtual HhPhieuNhapCcdcCt? IdphieuNhapCtNavigation { get; set; }

    public virtual HhPhieuXuatThanhLy? IdphieuXuatKhoNavigation { get; set; }
}
