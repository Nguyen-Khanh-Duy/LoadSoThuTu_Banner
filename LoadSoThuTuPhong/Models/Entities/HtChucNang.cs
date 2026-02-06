using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtChucNang
{
    public long Id { get; set; }

    public string? MaChucNang { get; set; }

    public string? TenChucNang { get; set; }

    public string? PhanLoai { get; set; }

    public int? Cap1 { get; set; }

    public int? Cap2 { get; set; }

    public long? IdphanHe { get; set; }

    public virtual ICollection<HtQuyenVaiTro> HtQuyenVaiTros { get; set; } = new List<HtQuyenVaiTro>();

    public virtual HtPhanHe? IdphanHeNavigation { get; set; }
}
