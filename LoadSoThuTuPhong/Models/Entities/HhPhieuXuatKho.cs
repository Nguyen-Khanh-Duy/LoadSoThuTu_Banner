using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuXuatKho
{
    public long Id { get; set; }

    public string? SoPx { get; set; }

    public bool? XuatNoi { get; set; }

    public long? Idcnnhan { get; set; }

    public long? Idbn { get; set; }

    public long? Idcn { get; set; }

    public long? Idnv { get; set; }

    public long? Idnvtao { get; set; }

    public string? SoHd { get; set; }

    public DateTime? NgayHd { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? NgayTao { get; set; }

    public long? Idnvnhan { get; set; }

    public DateTime? NgayNhan { get; set; }

    public long? ThongTinKhachHang { get; set; }

    public long? IdnguonNhapXuat { get; set; }

    public long? IdnoiSuDung { get; set; }

    public bool? DaThanhToan { get; set; }

    public bool? XuatBan { get; set; }

    public long? IdToaThuoc { get; set; }

    public long? IdphieuDeNghi { get; set; }

    public long? IdvaoVien { get; set; }

    public long? Idkip { get; set; }

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhos { get; set; } = new List<HhPhieuNhapKho>();

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual QlToaThuoc? IdToaThuocNavigation { get; set; }

    public virtual DmBenhNhan? IdbnNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmChiNhanh? IdcnnhanNavigation { get; set; }

    public virtual DmKip? IdkipNavigation { get; set; }

    public virtual HhDmNguonNhapXuat? IdnguonNhapXuatNavigation { get; set; }

    public virtual HhDmNoiSuDung? IdnoiSuDungNavigation { get; set; }

    public virtual DmNhanVien? IdnvNavigation { get; set; }

    public virtual DmNhanVien? IdnvnhanNavigation { get; set; }

    public virtual DmNhanVien? IdnvtaoNavigation { get; set; }

    public virtual QlPhieuDeNghiCapHang? IdphieuDeNghiNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlPhieuThuNoCt> QlPhieuThuNoCts { get; set; } = new List<QlPhieuThuNoCt>();
}
