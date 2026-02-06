using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmNhanVien
{
    public long Id { get; set; }

    public string? MaNhanVien { get; set; }

    public string? TenNhanVien { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public long? Idgt { get; set; }

    public string? DiaChi { get; set; }

    public string? QueQuan { get; set; }

    public string? DienThoai { get; set; }

    public string? Mabhxh { get; set; }

    public string? Macchn { get; set; }

    public DateOnly? Ngaycapcchn { get; set; }

    public string? Noicapcchn { get; set; }

    public string? Phamvicm { get; set; }

    public string? Vbphancong { get; set; }

    public long? Idnh { get; set; }

    public long? Idcd { get; set; }

    public string? SoTk { get; set; }

    public string? MaSoThue { get; set; }

    public string? KyTuDinhDanh { get; set; }

    public bool? NhomBsktv { get; set; }

    public bool? NhomDuoc { get; set; }

    public bool? NhomKeToan { get; set; }

    public bool? NhomPhuTa { get; set; }

    public bool? NhomKhac { get; set; }

    public long? Idtk { get; set; }

    public long? Idcn { get; set; }

    public bool? Active { get; set; }

    public bool? NhomTiepTan { get; set; }

    public string? MauLichHen { get; set; }

    public string? TenCu { get; set; }

    public string? TenVietGon { get; set; }

    public virtual ICollection<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; } = new List<DmBenhNhanDuBi>();

    public virtual ICollection<DmBenhNhan> DmBenhNhanIdnhanVienCapNhatNavigations { get; set; } = new List<DmBenhNhan>();

    public virtual ICollection<DmBenhNhan> DmBenhNhanIdnhanVienTaoNavigations { get; set; } = new List<DmBenhNhan>();

    public virtual ICollection<DmBntheoBacSi> DmBntheoBacSis { get; set; } = new List<DmBntheoBacSi>();

    public virtual ICollection<DmBoDungCu> DmBoDungCus { get; set; } = new List<DmBoDungCu>();

    public virtual ICollection<DmChiNhanh> DmChiNhanhIdkeToanNavigations { get; set; } = new List<DmChiNhanh>();

    public virtual ICollection<DmChiNhanh> DmChiNhanhIdthuQuyNavigations { get; set; } = new List<DmChiNhanh>();

    public virtual ICollection<DmChiNhanh> DmChiNhanhIdthuTruongDonViNavigations { get; set; } = new List<DmChiNhanh>();

    public virtual ICollection<DmTiLeHoaHong> DmTiLeHoaHongs { get; set; } = new List<DmTiLeHoaHong>();

    public virtual ICollection<DmTiLeLuong> DmTiLeLuongs { get; set; } = new List<DmTiLeLuong>();

    public virtual ICollection<HhPhieuNhapCcdc> HhPhieuNhapCcdcIdnhanVienNhapNavigations { get; set; } = new List<HhPhieuNhapCcdc>();

    public virtual ICollection<HhPhieuNhapCcdc> HhPhieuNhapCcdcIdnhanVienSuaNavigations { get; set; } = new List<HhPhieuNhapCcdc>();

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhos { get; set; } = new List<HhPhieuNhapKho>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhoIdnvNavigations { get; set; } = new List<HhPhieuXuatKho>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhoIdnvnhanNavigations { get; set; } = new List<HhPhieuXuatKho>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhoIdnvtaoNavigations { get; set; } = new List<HhPhieuXuatKho>();

    public virtual ICollection<HhPhieuXuatThanhLy> HhPhieuXuatThanhLies { get; set; } = new List<HhPhieuXuatThanhLy>();

    public virtual ICollection<HtLichNghi> HtLichNghis { get; set; } = new List<HtLichNghi>();

    public virtual ICollection<HtPhanQuyen> HtPhanQuyens { get; set; } = new List<HtPhanQuyen>();

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmGioiTinh? IdgtNavigation { get; set; }

    public virtual HhDmNganHang? IdnhNavigation { get; set; }

    public virtual HtTaiKhoanDangNhap? IdtkNavigation { get; set; }

    public virtual ICollection<QlChanDoan> QlChanDoanIdbacSiThucHienNavigations { get; set; } = new List<QlChanDoan>();

    public virtual ICollection<QlChanDoan> QlChanDoanIdnhanVienThucHienNavigations { get; set; } = new List<QlChanDoan>();

    public virtual ICollection<QlChiDinh> QlChiDinhs { get; set; } = new List<QlChiDinh>();

    public virtual ICollection<QlHen> QlHens { get; set; } = new List<QlHen>();

    public virtual ICollection<QlHinhAnh> QlHinhAnhs { get; set; } = new List<QlHinhAnh>();

    public virtual ICollection<QlHoaDon> QlHoaDons { get; set; } = new List<QlHoaDon>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdBstuVanThemNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdDdtuVanThemNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdbacSiNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdnhanVienGuiNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdnhanVienNhanNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdnhanVienTraNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdnvtaoNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCtIdtroThuNavigations { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlKeHoachDieuTri> QlKeHoachDieuTriIdbacSiNavigations { get; set; } = new List<QlKeHoachDieuTri>();

    public virtual ICollection<QlKeHoachDieuTri> QlKeHoachDieuTriIdttNavigations { get; set; } = new List<QlKeHoachDieuTri>();

    public virtual ICollection<QlKhamTongQuat> QlKhamTongQuats { get; set; } = new List<QlKhamTongQuat>();

    public virtual ICollection<QlMuonTra> QlMuonTraIdnhanVienMuonNavigations { get; set; } = new List<QlMuonTra>();

    public virtual ICollection<QlMuonTra> QlMuonTraIdnhanVienTraNavigations { get; set; } = new List<QlMuonTra>();

    public virtual ICollection<QlPhieuChi> QlPhieuChis { get; set; } = new List<QlPhieuChi>();

    public virtual ICollection<QlPhieuDatCoc> QlPhieuDatCocIdnvtaoNavigations { get; set; } = new List<QlPhieuDatCoc>();

    public virtual ICollection<QlPhieuDatCoc> QlPhieuDatCocIdnvtraNavigations { get; set; } = new List<QlPhieuDatCoc>();

    public virtual ICollection<QlPhieuDeNghiCapHang> QlPhieuDeNghiCapHangIdnhanVienDeNghiNavigations { get; set; } = new List<QlPhieuDeNghiCapHang>();

    public virtual ICollection<QlPhieuDeNghiCapHang> QlPhieuDeNghiCapHangIdnhanVienNavigations { get; set; } = new List<QlPhieuDeNghiCapHang>();

    public virtual ICollection<QlPhieuDeNghi> QlPhieuDeNghis { get; set; } = new List<QlPhieuDeNghi>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTriIdbacSiNavigations { get; set; } = new List<QlPhieuDieuTri>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTriIdtroThuNavigations { get; set; } = new List<QlPhieuDieuTri>();

    public virtual ICollection<QlPhieuDuTru> QlPhieuDuTruIdnhanVienDuTruNavigations { get; set; } = new List<QlPhieuDuTru>();

    public virtual ICollection<QlPhieuDuTru> QlPhieuDuTruIdnhanVienNavigations { get; set; } = new List<QlPhieuDuTru>();

    public virtual ICollection<QlPhieuLaBo> QlPhieuLaBos { get; set; } = new List<QlPhieuLaBo>();

    public virtual ICollection<QlPhieuThuNo> QlPhieuThuNos { get; set; } = new List<QlPhieuThuNo>();

    public virtual ICollection<QlPhieuThu> QlPhieuThus { get; set; } = new List<QlPhieuThu>();

    public virtual ICollection<QlPhieuTraNo> QlPhieuTraNos { get; set; } = new List<QlPhieuTraNo>();

    public virtual ICollection<QlPhieuVatLieu> QlPhieuVatLieus { get; set; } = new List<QlPhieuVatLieu>();

    public virtual ICollection<QlQuaTrinhTinhLuong> QlQuaTrinhTinhLuongIdbacSiNavigations { get; set; } = new List<QlQuaTrinhTinhLuong>();

    public virtual ICollection<QlQuaTrinhTinhLuong> QlQuaTrinhTinhLuongIdtroThuNavigations { get; set; } = new List<QlQuaTrinhTinhLuong>();

    public virtual ICollection<QlSoHd> QlSoHds { get; set; } = new List<QlSoHd>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();

    public virtual ICollection<QlToaThuoc> QlToaThuocs { get; set; } = new List<QlToaThuoc>();

    public virtual ICollection<QlVaoVien> QlVaoVienIdnhanVienKetThucNavigations { get; set; } = new List<QlVaoVien>();

    public virtual ICollection<QlVaoVien> QlVaoVienIdnhanVienTaoNavigations { get; set; } = new List<QlVaoVien>();

    public virtual ICollection<SttCapSoTheoBacSi> SttCapSoTheoBacSis { get; set; } = new List<SttCapSoTheoBacSi>();

    public virtual ICollection<TinhLuongPhanTramChinhNha> TinhLuongPhanTramChinhNhas { get; set; } = new List<TinhLuongPhanTramChinhNha>();

    public virtual ICollection<TinhLuongTongHopLuong> TinhLuongTongHopLuongs { get; set; } = new List<TinhLuongTongHopLuong>();
}
