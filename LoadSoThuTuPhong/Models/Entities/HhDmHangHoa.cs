using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmHangHoa
{
    public long Id { get; set; }

    public string MaHh { get; set; } = null!;

    public string? TenHh { get; set; }

    public string? Avatar { get; set; }

    public long? Idnhh { get; set; }

    public long? Idhsx { get; set; }

    public long? Idnsx { get; set; }

    public long? Iddvtchinh { get; set; }

    public string? GhiChu { get; set; }

    public double? TiLeSi { get; set; }

    public double? TiLeLe { get; set; }

    public double? GiaBanSi { get; set; }

    public double? GiaBanLe { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public bool Active { get; set; }

    public long? IdDuongDung { get; set; }

    public string? HoatChat { get; set; }

    public virtual ICollection<DmBoDungCuCt> DmBoDungCuCts { get; set; } = new List<DmBoDungCuCt>();

    public virtual ICollection<DmCoSoVatTuThietYeu> DmCoSoVatTuThietYeus { get; set; } = new List<DmCoSoVatTuThietYeu>();

    public virtual ICollection<HhDmHangHoaNcc> HhDmHangHoaNccs { get; set; } = new List<HhDmHangHoaNcc>();

    public virtual ICollection<HhHangTonKho> HhHangTonKhos { get; set; } = new List<HhHangTonKho>();

    public virtual ICollection<HhPhieuNhapCcdcCt> HhPhieuNhapCcdcCts { get; set; } = new List<HhPhieuNhapCcdcCt>();

    public virtual ICollection<HhPhieuNhapCt> HhPhieuNhapCts { get; set; } = new List<HhPhieuNhapCt>();

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual ICollection<HhPhieuXuatThanhLyCt> HhPhieuXuatThanhLyCts { get; set; } = new List<HhPhieuXuatThanhLyCt>();

    public virtual DmDuongDung? IdDuongDungNavigation { get; set; }

    public virtual HhDmDonViTinh? IddvtchinhNavigation { get; set; }

    public virtual HhDmHangSanXuat? IdhsxNavigation { get; set; }

    public virtual HhDmNhomHangHoa? IdnhhNavigation { get; set; }

    public virtual HhDmNuocSanXuat? IdnsxNavigation { get; set; }

    public virtual ICollection<QlDinhMucVatTuTieuHao> QlDinhMucVatTuTieuHaos { get; set; } = new List<QlDinhMucVatTuTieuHao>();

    public virtual ICollection<QlPhieuDeNghiCapHangCt> QlPhieuDeNghiCapHangCts { get; set; } = new List<QlPhieuDeNghiCapHangCt>();

    public virtual ICollection<QlPhieuDuTruCt> QlPhieuDuTruCts { get; set; } = new List<QlPhieuDuTruCt>();

    public virtual ICollection<QlPhieuVatLieuCt> QlPhieuVatLieuCts { get; set; } = new List<QlPhieuVatLieuCt>();

    public virtual ICollection<QlToaThuocCt> QlToaThuocCts { get; set; } = new List<QlToaThuocCt>();

    public virtual ICollection<QlToaThuocMauCt> QlToaThuocMauCts { get; set; } = new List<QlToaThuocMauCt>();

    public virtual ICollection<TinhLuongHoaHongVatLieu> TinhLuongHoaHongVatLieus { get; set; } = new List<TinhLuongHoaHongVatLieu>();
}
