using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlHinhAnh
{
    public long Id { get; set; }

    public long? Idcn { get; set; }

    public long? IdvaoVien { get; set; }

    public long? Idcd { get; set; }

    public string? LoaiHinh { get; set; }

    public string? MaHa { get; set; }

    public DateTime? Ngay { get; set; }

    public string? DuongDan { get; set; }

    public string? GhiChu { get; set; }

    public bool? AnhMarketting { get; set; }

    public long? IdnhanVienThem { get; set; }

    public virtual QlChiDinh? IdcdNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienThemNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
