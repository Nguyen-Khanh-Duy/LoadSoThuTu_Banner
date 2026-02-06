using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuNhapCcdcCt
{
    public long Id { get; set; }

    public long? IdphieuNhapKho { get; set; }

    public long? IdhangHoa { get; set; }

    public double? SoLuongNhap { get; set; }

    public long? IddonViTinhNhap { get; set; }

    public double? DonGiaNhap { get; set; }

    public double? ThanhTien { get; set; }

    public double? ChiecKhau { get; set; }

    public double? ThueVat { get; set; }

    public string? SoLo { get; set; }

    public DateOnly? HanDung { get; set; }

    public DateOnly? NgaySanXuat { get; set; }

    public string? GhiChuHangNhap { get; set; }

    public double? SldaXuat { get; set; }

    public virtual ICollection<HhPhieuXuatThanhLyCt> HhPhieuXuatThanhLyCts { get; set; } = new List<HhPhieuXuatThanhLyCt>();

    public virtual HhDmDonViTinh? IddonViTinhNhapNavigation { get; set; }

    public virtual HhDmHangHoa? IdhangHoaNavigation { get; set; }

    public virtual HhPhieuNhapCcdc? IdphieuNhapKhoNavigation { get; set; }
}
