using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuThuCt
{
    public long Id { get; set; }

    public long? IdphieuThu { get; set; }

    public long? IdkhoanThu { get; set; }

    public string? DienGiai { get; set; }

    public double? SoTien { get; set; }

    public virtual DmKhoanThuChi? IdkhoanThuNavigation { get; set; }

    public virtual QlPhieuThu? IdphieuThuNavigation { get; set; }
}
