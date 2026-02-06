using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTiLeLuong
{
    public long Id { get; set; }

    public long? IdCn { get; set; }

    public long? IdnhomDvkt { get; set; }

    public double? TyLe { get; set; }

    public long? IdnhanVien { get; set; }

    public bool? Chung { get; set; }

    public DateOnly? TuNgay { get; set; }

    public DateOnly? DenNgay { get; set; }

    public virtual DmChiNhanh? IdCnNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }

    public virtual DmNhomDichVuKyThuat? IdnhomDvktNavigation { get; set; }
}
