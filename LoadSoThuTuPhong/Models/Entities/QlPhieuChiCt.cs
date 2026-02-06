using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuChiCt
{
    public long Id { get; set; }

    public long? IdphieuChi { get; set; }

    public long? IdkhoanChi { get; set; }

    public string? DienGiai { get; set; }

    public double? SoTien { get; set; }

    public virtual DmKhoanThuChi? IdkhoanChiNavigation { get; set; }

    public virtual QlPhieuChi? IdphieuChiNavigation { get; set; }
}
