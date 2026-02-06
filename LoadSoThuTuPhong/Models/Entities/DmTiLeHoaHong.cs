using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmTiLeHoaHong
{
    public long Id { get; set; }

    public long? IdnhanVien { get; set; }

    public long? Iddvkt { get; set; }

    public double? TyLe { get; set; }

    public long? IdCn { get; set; }

    public virtual DmChiNhanh? IdCnNavigation { get; set; }

    public virtual DmDichVuKyThuat? IddvktNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }
}
