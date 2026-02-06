using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TinhLuongPhanTramChinhNha
{
    public long Id { get; set; }

    public long? IdnhanVien { get; set; }

    public double? TyLe { get; set; }

    public bool? ChinhNhaMoi { get; set; }

    public double? TyLeChinhNhaMoi { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }
}
