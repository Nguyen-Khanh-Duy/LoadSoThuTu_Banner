using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlChiDinh
{
    public long Id { get; set; }

    public long? Idcn { get; set; }

    public long? IdvaoVien { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? NgayGioChiDinh { get; set; }

    public long? IdbacSi { get; set; }

    public long? Iddvkt { get; set; }

    public double? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public DateTime? NgayGioKetQua { get; set; }

    public long? IddoiTac { get; set; }

    public string? GhiChu { get; set; }

    public virtual DmNhanVien? IdbacSiNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmDoiTac? IddoiTacNavigation { get; set; }

    public virtual DmDichVuKyThuat? IddvktNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }

    public virtual ICollection<QlHinhAnh> QlHinhAnhs { get; set; } = new List<QlHinhAnh>();
}
