using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlKeHoachDieuTriCt
{
    public long Id { get; set; }

    public long? IdkeHoach { get; set; }

    public long? IdcongViec { get; set; }

    public string? Rang { get; set; }

    public double? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public double? TileGiam { get; set; }

    public double? SoTienGiam { get; set; }

    public int? SoLanHen { get; set; }

    public bool? KeHoach1 { get; set; }

    public bool? KeHoach2 { get; set; }

    public bool? KeHoach3 { get; set; }

    public bool? KeHoach4 { get; set; }

    public long? IdphieuDieuTri { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public long? IdketQuaDieuTri { get; set; }

    public bool? DaXuLy { get; set; }

    public long? Idncclabo { get; set; }

    public long? IdphucHinh { get; set; }

    public string? Mau { get; set; }

    public DateTime? NgayGui { get; set; }

    public DateTime? NgayThu { get; set; }

    public long? IdnhanVienGui { get; set; }

    public DateTime? NgayNhan { get; set; }

    public long? IdnhanVienNhan { get; set; }

    public bool? DaNhan { get; set; }

    public double? SoLuongLabo { get; set; }

    public double? DonGiaLabo { get; set; }

    public double? TyLeGiamLabo { get; set; }

    public int? SoLanThu { get; set; }

    public long? IdbacSi { get; set; }

    public long? IdtroThu { get; set; }

    public string? MaSinhVien { get; set; }

    public string? GhiChu { get; set; }

    public bool? DaDuyetGiam { get; set; }

    public long? IdnhanVienTra { get; set; }

    public double? SoTienTra { get; set; }

    public DateTime? NgayTra { get; set; }

    public string? GhiChuTra { get; set; }

    public bool? LaboKhoan { get; set; }

    public bool? DaGanLabo { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NgayTaoMap { get; set; }

    public long? Idbslabo { get; set; }

    public string? GhiChuLabo { get; set; }

    public long? IdBstuVanThem { get; set; }

    public long? IdDdtuVanThem { get; set; }

    public int? Stt { get; set; }

    public bool? XoaCongNo { get; set; }

    public DateTime? NgayXoaCongNo { get; set; }

    public long? Idkip { get; set; }

    public long? Idnvtao { get; set; }

    public long? IdNhomChiPhiLabo { get; set; }

    public long? IdKipLabo { get; set; }

    public bool? KeHoach { get; set; }

    public DateTime? NgayXoaNo { get; set; }

    public double? SoTienXoaNo { get; set; }

    public long? IdnguoiXoaNo { get; set; }

    public string? GhiChuXoaNo { get; set; }

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual DmNhanVien? IdBstuVanThemNavigation { get; set; }

    public virtual DmNhanVien? IdDdtuVanThemNavigation { get; set; }

    public virtual DmNhanVien? IdbacSiNavigation { get; set; }

    public virtual DmDichVuKyThuat? IdcongViecNavigation { get; set; }

    public virtual QlKeHoachDieuTri? IdkeHoachNavigation { get; set; }

    public virtual DmKetQuaDieuTri? IdketQuaDieuTriNavigation { get; set; }

    public virtual HhDmNhaCungCap? IdncclaboNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienGuiNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNhanNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienTraNavigation { get; set; }

    public virtual DmNhanVien? IdnvtaoNavigation { get; set; }

    public virtual DmPhucHinh? IdphucHinhNavigation { get; set; }

    public virtual DmNhanVien? IdtroThuNavigation { get; set; }

    public virtual ICollection<QlHoaDonCt> QlHoaDonCts { get; set; } = new List<QlHoaDonCt>();

    public virtual ICollection<QlPhieuDeNghiCt> QlPhieuDeNghiCts { get; set; } = new List<QlPhieuDeNghiCt>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();

    public virtual ICollection<QlPhieuLaBoCt> QlPhieuLaBoCts { get; set; } = new List<QlPhieuLaBoCt>();

    public virtual ICollection<QlPhieuVatLieuCt> QlPhieuVatLieuCts { get; set; } = new List<QlPhieuVatLieuCt>();

    public virtual ICollection<QlQuaTrinhTinhLuong> QlQuaTrinhTinhLuongs { get; set; } = new List<QlQuaTrinhTinhLuong>();

    public virtual ICollection<QlThuTienDieuTriCt> QlThuTienDieuTriCts { get; set; } = new List<QlThuTienDieuTriCt>();
}
