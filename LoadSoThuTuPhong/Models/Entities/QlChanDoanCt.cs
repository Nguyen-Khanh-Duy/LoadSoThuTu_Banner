using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlChanDoanCt
{
    public long Id { get; set; }

    public long? IdchanDoan { get; set; }

    public long? IdmaBenhIcd10 { get; set; }

    public string? MaBenh { get; set; }

    public string? TenBenh { get; set; }

    public bool? BanDau { get; set; }

    public bool? BenhChinh { get; set; }

    public bool? PhanBiet { get; set; }

    public virtual QlChanDoan? IdchanDoanNavigation { get; set; }

    public virtual DmIcd? IdmaBenhIcd10Navigation { get; set; }
}
