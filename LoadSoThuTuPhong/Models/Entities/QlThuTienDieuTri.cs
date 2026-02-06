using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlThuTienDieuTri
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public long? Idcn { get; set; }

    public long? IdvaoVien { get; set; }

    public DateOnly? Ngay { get; set; }

    public long? IdkeHoach { get; set; }

    public long? IdnhanVien { get; set; }

    public string? GhiChu { get; set; }

    public bool? Huy { get; set; }

    public bool? ChuyenKhoan { get; set; }

    public long? Idkip { get; set; }

    public long? IddoiTacBh { get; set; }

    public long? IdnganHangDn { get; set; }

    public long? IdhtthanhToan { get; set; }

    public long? IdphieuDatCoc { get; set; }

    public string? LoaiHd { get; set; }

    public string? Seri { get; set; }

    public string? Quyen { get; set; }

    public string? SoBienLai { get; set; }

    public DateTime? NgayBaoCao { get; set; }

    public bool? KhoaSo { get; set; }

    public string? GhiChuRieng { get; set; }

    public int? ChongTrungUnique { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmDoiTacBaoHiem? IddoiTacBhNavigation { get; set; }

    public virtual DmHinhThucThanhToan? IdhtthanhToanNavigation { get; set; }

    public virtual QlKeHoachDieuTri? IdkeHoachNavigation { get; set; }

    public virtual DmKip? IdkipNavigation { get; set; }

    public virtual DmNganHangDoanhNghiep? IdnganHangDnNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }

    public virtual QlPhieuDatCoc? IdphieuDatCocNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlHoaDon> QlHoaDons { get; set; } = new List<QlHoaDon>();

    public virtual ICollection<QlThuTienDieuTriCt> QlThuTienDieuTriCts { get; set; } = new List<QlThuTienDieuTriCt>();

    public virtual ICollection<QlThuTienDieuTriDatCoc> QlThuTienDieuTriDatCocs { get; set; } = new List<QlThuTienDieuTriDatCoc>();
}
