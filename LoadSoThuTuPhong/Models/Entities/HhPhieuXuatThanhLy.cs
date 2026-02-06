using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhPhieuXuatThanhLy
{
    public long Id { get; set; }

    public string? SoPhieuXuat { get; set; }

    public DateTime? NgayGioXuat { get; set; }

    public long? IdlyDoXuat { get; set; }

    public string? GhiChuPhieuXuat { get; set; }

    public long? IdnhanVienXuat { get; set; }

    public virtual ICollection<HhPhieuXuatThanhLyCt> HhPhieuXuatThanhLyCts { get; set; } = new List<HhPhieuXuatThanhLyCt>();

    public virtual DmLyDoXuat? IdlyDoXuatNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienXuatNavigation { get; set; }
}
