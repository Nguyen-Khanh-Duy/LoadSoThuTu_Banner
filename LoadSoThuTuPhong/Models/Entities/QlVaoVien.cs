using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlVaoVien
{
    public long Id { get; set; }

    public string MaVaoVien { get; set; } = null!;

    public long IdbenhNhan { get; set; }

    public long IdchiNhanh { get; set; }

    public DateTime NgayVao { get; set; }

    public long IdlyDoVaoVien { get; set; }

    public long? IdmarKetting { get; set; }

    public long? IdtinhCach { get; set; }

    public string? GhiChuLucVao { get; set; }

    public long IdnhanVienTao { get; set; }

    public DateTime? NgayRa { get; set; }

    public long? IdlyDoRaVien { get; set; }

    public string? GhiChuLucRa { get; set; }

    public long? IdnhanVienKetThuc { get; set; }

    public long? IdkeHoach { get; set; }

    public string? MaKeHoach { get; set; }

    public bool HieuLuc { get; set; }

    public bool? Kham { get; set; }

    public bool? DieuTri { get; set; }

    public long? IdphongHienTai { get; set; }

    public long? IdbacSiHienTai { get; set; }

    public virtual ICollection<CaLuuTruKy> CaLuuTruKies { get; set; } = new List<CaLuuTruKy>();

    public virtual ICollection<DmBntheoBacSi> DmBntheoBacSis { get; set; } = new List<DmBntheoBacSi>();

    public virtual ICollection<DmRangCt> DmRangCts { get; set; } = new List<DmRangCt>();

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();

    public virtual DmBenhNhan IdbenhNhanNavigation { get; set; } = null!;

    public virtual DmChiNhanh IdchiNhanhNavigation { get; set; } = null!;

    public virtual DmLyDoRaVien? IdlyDoRaVienNavigation { get; set; }

    public virtual DmLyDoVaoVien IdlyDoVaoVienNavigation { get; set; } = null!;

    public virtual DmMarKetting? IdmarKettingNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienKetThucNavigation { get; set; }

    public virtual DmNhanVien IdnhanVienTaoNavigation { get; set; } = null!;

    public virtual DmPhongThucHien? IdphongHienTaiNavigation { get; set; }

    public virtual DmTinhCach? IdtinhCachNavigation { get; set; }

    public virtual ICollection<QlBenhAn> QlBenhAns { get; set; } = new List<QlBenhAn>();

    public virtual ICollection<QlChanDoan> QlChanDoans { get; set; } = new List<QlChanDoan>();

    public virtual ICollection<QlChiDinh> QlChiDinhs { get; set; } = new List<QlChiDinh>();

    public virtual ICollection<QlHen> QlHens { get; set; } = new List<QlHen>();

    public virtual ICollection<QlHinhAnh> QlHinhAnhs { get; set; } = new List<QlHinhAnh>();

    public virtual ICollection<QlHoaDonCt> QlHoaDonCts { get; set; } = new List<QlHoaDonCt>();

    public virtual ICollection<QlKeHoachDieuTri> QlKeHoachDieuTris { get; set; } = new List<QlKeHoachDieuTri>();

    public virtual ICollection<QlMuonTra> QlMuonTras { get; set; } = new List<QlMuonTra>();

    public virtual ICollection<QlPhieuDeNghi> QlPhieuDeNghis { get; set; } = new List<QlPhieuDeNghi>();

    public virtual ICollection<QlPhieuLaBo> QlPhieuLaBos { get; set; } = new List<QlPhieuLaBo>();

    public virtual ICollection<QlPhieuVatLieu> QlPhieuVatLieus { get; set; } = new List<QlPhieuVatLieu>();

    public virtual ICollection<QlThuTienDieuTri> QlThuTienDieuTris { get; set; } = new List<QlThuTienDieuTri>();

    public virtual ICollection<QlToaThuoc> QlToaThuocs { get; set; } = new List<QlToaThuoc>();

    public virtual ICollection<TinhLuongTongHopLuong> TinhLuongTongHopLuongs { get; set; } = new List<TinhLuongTongHopLuong>();
}
