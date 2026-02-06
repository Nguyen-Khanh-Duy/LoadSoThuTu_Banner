using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlToaThuoc
{
    public long Id { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdbacSiKe { get; set; }

    public string? MaToa { get; set; }

    public DateTime? NgayKe { get; set; }

    public double? SoNgay { get; set; }

    public string? LoaiToa { get; set; }

    public string? TrieuChung { get; set; }

    public string? GhiChu { get; set; }

    public DateOnly? NgayTaiKham { get; set; }

    public bool? XuatBan { get; set; }

    public bool? GuiTinNhanThanhCong { get; set; }

    public virtual ICollection<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; } = new List<HhPhieuXuatKho>();

    public virtual DmNhanVien? IdbacSiKeNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlToaThuocCd> QlToaThuocCds { get; set; } = new List<QlToaThuocCd>();

    public virtual ICollection<QlToaThuocCt> QlToaThuocCts { get; set; } = new List<QlToaThuocCt>();
}
