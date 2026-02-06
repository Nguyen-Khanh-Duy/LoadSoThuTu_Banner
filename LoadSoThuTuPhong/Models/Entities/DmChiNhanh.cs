using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmChiNhanh
{
    public long Id { get; set; }

    public string? MaChiNhanh { get; set; }

    public string? TenChiNhanh { get; set; }

    public string? TenCoQuanChuyenMon { get; set; }

    public string? DiaChi { get; set; }

    public string? DiaChi2 { get; set; }

    public string? DienThoai { get; set; }

    public string? DienThoai2 { get; set; }

    public string? Email { get; set; }

    public string? Logo { get; set; }

    public bool? Active { get; set; }

    public long? IdnganHang { get; set; }

    public string? Mst { get; set; }

    public string? SoTk { get; set; }

    public string? ChuTk { get; set; }

    public int? Sttbn { get; set; }

    public bool? KhoTong { get; set; }

    public long? IdthuTruongDonVi { get; set; }

    public long? IdthuQuy { get; set; }

    public long? IdkeToan { get; set; }

    public string? MaCskcb { get; set; }

    public string? TenCskcb { get; set; }

    public string? ApicongVan { get; set; }

    public string? ApisignPad { get; set; }

    public bool SinhVien { get; set; }

    public virtual ICollection<BenhNhanTheoNgay> BenhNhanTheoNgays { get; set; } = new List<BenhNhanTheoNgay>();

    public virtual ICollection<DmBanner> DmBanners { get; set; } = new List<DmBanner>();

    public virtual ICollection<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; } = new List<DmBenhNhanDuBi>();

    public virtual ICollection<DmBenhNhan> DmBenhNhans { get; set; } = new List<DmBenhNhan>();

    public virtual ICollection<DmCoSoVatTuThietYeu> DmCoSoVatTuThietYeus { get; set; } = new List<DmCoSoVatTuThietYeu>();

    public virtual ICollection<DmDichVuKyThuatGium> DmDichVuKyThuatGia { get; set; } = new List<DmDichVuKyThuatGium>();

    public virtual ICollection<DmDichVuKyThuatSoLanDung> DmDichVuKyThuatSoLanDungs { get; set; } = new List<DmDichVuKyThuatSoLanDung>();

    public virtual ICollection<DmNganHangDoanhNghiep> DmNganHangDoanhNghieps { get; set; } = new List<DmNganHangDoanhNghiep>();

    public virtual ICollection<DmNhanVien> DmNhanViens { get; set; } = new List<DmNhanVien>();

    public virtual ICollection<DmNoiSuDung> DmNoiSuDungs { get; set; } = new List<DmNoiSuDung>();

    public virtual ICollection<DmPhongThucHien> DmPhongThucHiens { get; set; } = new List<DmPhongThucHien>();

    public virtual ICollection<DmTiLeHoaHong> DmTiLeHoaHongs { get; set; } = new List<DmTiLeHoaHong>();

    public virtual ICollection<DmTiLeLuong> DmTiLeLuongs { get; set; } = new List<DmTiLeLuong>();

    public virtual ICollection<HhPhieuNhapCcdc> HhPhieuNhapCcdcs { get; set; } = new List<HhPhieuNhapCcdc>();

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhoIdcnNavigations { get; set; } = new List<HhPhieuNhapKho>();

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhoIdcnxuatNavigations { get; set; } = new List<HhPhieuNhapKho>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhoIdcnNavigations { get; set; } = new List<HhPhieuXuatKho>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhoIdcnnhanNavigations { get; set; } = new List<HhPhieuXuatKho>();

    public virtual ICollection<HtPhanQuyen> HtPhanQuyens { get; set; } = new List<HtPhanQuyen>();

    public virtual DmNhanVien? IdkeToanNavigation { get; set; }

    public virtual HhDmNganHang? IdnganHangNavigation { get; set; }

    public virtual DmNhanVien? IdthuQuyNavigation { get; set; }

    public virtual DmNhanVien? IdthuTruongDonViNavigation { get; set; }

    public virtual ICollection<QlChiDinh> QlChiDinhs { get; set; } = new List<QlChiDinh>();

    public virtual ICollection<QlHen> QlHens { get; set; } = new List<QlHen>();

    public virtual ICollection<QlHinhAnh> QlHinhAnhs { get; set; } = new List<QlHinhAnh>();

    public virtual ICollection<QlHoaDon> QlHoaDons { get; set; } = new List<QlHoaDon>();

    public virtual ICollection<QlPhieuChi> QlPhieuChis { get; set; } = new List<QlPhieuChi>();

    public virtual ICollection<QlPhieuDeNghiCapHang> QlPhieuDeNghiCapHangIdCnnhanDeNghiNavigations { get; set; } = new List<QlPhieuDeNghiCapHang>();

    public virtual ICollection<QlPhieuDeNghiCapHang> QlPhieuDeNghiCapHangIdchiNhanhDeNghiNavigations { get; set; } = new List<QlPhieuDeNghiCapHang>();

    public virtual ICollection<QlPhieuDeNghi> QlPhieuDeNghis { get; set; } = new List<QlPhieuDeNghi>();

    public virtual ICollection<QlPhieuDuTru> QlPhieuDuTrus { get; set; } = new List<QlPhieuDuTru>();

    public virtual ICollection<QlPhieuLaBo> QlPhieuLaBos { get; set; } = new List<QlPhieuLaBo>();

    public virtual ICollection<QlPhieuThuNo> QlPhieuThuNoIdcnNavigations { get; set; } = new List<QlPhieuThuNo>();

    public virtual ICollection<QlPhieuThuNo> QlPhieuThuNoIdcnnhapNavigations { get; set; } = new List<QlPhieuThuNo>();

    public virtual ICollection<QlPhieuThu> QlPhieuThus { get; set; } = new List<QlPhieuThu>();

    public virtual ICollection<QlPhieuTraNo> QlPhieuTraNoIdcnNavigations { get; set; } = new List<QlPhieuTraNo>();

    public virtual ICollection<QlPhieuTraNo> QlPhieuTraNoIdcnxuatNavigations { get; set; } = new List<QlPhieuTraNo>();

    public virtual ICollection<QlPhieuVatLieu> QlPhieuVatLieus { get; set; } = new List<QlPhieuVatLieu>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();

    public virtual ICollection<QlVaoVien> QlVaoViens { get; set; } = new List<QlVaoVien>();

    public virtual ICollection<TinhLuongDinhMucLaboTinhLuong> TinhLuongDinhMucLaboTinhLuongs { get; set; } = new List<TinhLuongDinhMucLaboTinhLuong>();
}
