using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBenhNhan
{
    public long Id { get; set; }

    public string MaBenhNhan { get; set; } = null!;

    public string TenBenhNhan { get; set; } = null!;

    public string? TenKhongDau { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public int NamSinh { get; set; }

    public long IdgioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public long? Idtinh { get; set; }

    public long? Idquan { get; set; }

    public long? Idpx { get; set; }

    public long? IdquocGia { get; set; }

    public long? IddanToc { get; set; }

    public string? Cccd { get; set; }

    public string DienThoai { get; set; } = null!;

    public string? DienThoaiKhac { get; set; }

    public string? Email { get; set; }

    public long? IdngheNghiep { get; set; }

    public long IdnguonTin { get; set; }

    public long? IdloaiBenhNhan { get; set; }

    public DateOnly? NgayDenLanDau { get; set; }

    public long? IdnhanVienCapNhat { get; set; }

    public long IdchiNhanh { get; set; }

    public long? IdchiNhanhTao { get; set; }

    public DateOnly? NgayChuyen { get; set; }

    public string? GhiChuChuyen { get; set; }

    public string? MaSvnhan { get; set; }

    public long? IdmoiLienHe { get; set; }

    public string? Tkzalo { get; set; }

    public string? TkfaceBook { get; set; }

    public string? Tktelegram { get; set; }

    public string? HoTenNguoiThan { get; set; }

    public string? LyDoDenKham { get; set; }

    public bool? Active { get; set; }

    public string? HoTenNguoiNha { get; set; }

    public string? DiaChiNguoiNha { get; set; }

    public string? DienThoaiNguoiNha { get; set; }

    public string? CccdnguoiNha { get; set; }

    public string? GhiChu { get; set; }

    public long? IdnhanVienTao { get; set; }

    public int? DuLieuCu { get; set; }

    public string? MaSinhVien { get; set; }

    public string? TinhCachBenhNhan { get; set; }

    public string? SoNhaTenDuong { get; set; }

    public int? Nam { get; set; }

    public long? IdTinhMoi { get; set; }

    public long? IdXaMoi { get; set; }

    public string? DiaChiMoi { get; set; }

    public DateTime? NgayTddc { get; set; }

    public string? LyDoDenKhamLanDau { get; set; }

    public string? MaSoThue { get; set; }

    public string? TenCongTyThue { get; set; }

    public string? DiaChiCongTyThue { get; set; }

    public string? EmailNhanHoaDon { get; set; }

    public virtual ICollection<ApiZlKetQuaZn> ApiZlKetQuaZns { get; set; } = new List<ApiZlKetQuaZn>();

    public virtual ICollection<BenhNhanTheoNgay> BenhNhanTheoNgays { get; set; } = new List<BenhNhanTheoNgay>();

    public virtual ICollection<CaLuuTruKy> CaLuuTruKies { get; set; } = new List<CaLuuTruKy>();

    public virtual ICollection<DmBntheoBacSi> DmBntheoBacSis { get; set; } = new List<DmBntheoBacSi>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();

    public virtual DmChiNhanh IdchiNhanhNavigation { get; set; } = null!;

    public virtual DmDanToc? IddanTocNavigation { get; set; }

    public virtual DmGioiTinh IdgioiTinhNavigation { get; set; } = null!;

    public virtual DmLoaiBenhNhan? IdloaiBenhNhanNavigation { get; set; }

    public virtual DmMoiLienHe? IdmoiLienHeNavigation { get; set; }

    public virtual DmNgheNghiep? IdngheNghiepNavigation { get; set; }

    public virtual DmNguonTin IdnguonTinNavigation { get; set; } = null!;

    public virtual DmNhanVien? IdnhanVienCapNhatNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienTaoNavigation { get; set; }

    public virtual DmXaCuTru? IdpxNavigation { get; set; }

    public virtual DmQuanCuTru? IdquanNavigation { get; set; }

    public virtual DmQuocGium? IdquocGiaNavigation { get; set; }

    public virtual DmTinhCuTru? IdtinhNavigation { get; set; }

    public virtual ICollection<QlChanDoan> QlChanDoans { get; set; } = new List<QlChanDoan>();

    public virtual ICollection<QlHen> QlHens { get; set; } = new List<QlHen>();

    public virtual ICollection<QlPhieuDatCoc> QlPhieuDatCocs { get; set; } = new List<QlPhieuDatCoc>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();

    public virtual ICollection<QlVaoVien> QlVaoViens { get; set; } = new List<QlVaoVien>();

    public virtual ICollection<TinhLuongTongHopLuong> TinhLuongTongHopLuongs { get; set; } = new List<TinhLuongTongHopLuong>();
}
