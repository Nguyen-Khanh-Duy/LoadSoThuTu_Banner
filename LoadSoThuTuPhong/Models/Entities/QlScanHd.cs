using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlScanHd
{
    public long Id { get; set; }

    public long? IdkeHoachDt { get; set; }

    public string? DuongDan { get; set; }

    public virtual QlKeHoachDieuTri? IdkeHoachDtNavigation { get; set; }
}
