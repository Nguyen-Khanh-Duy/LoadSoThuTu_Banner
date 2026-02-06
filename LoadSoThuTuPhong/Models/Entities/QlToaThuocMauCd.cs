using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlToaThuocMauCd
{
    public long Id { get; set; }

    public long? IdmauToa { get; set; }

    public string? MaBenh { get; set; }

    public string? TenBenh { get; set; }

    public bool? BanDau { get; set; }

    public bool? Chinh { get; set; }

    public bool? Khac { get; set; }

    public virtual QlToaThuocMau? IdmauToaNavigation { get; set; }
}
