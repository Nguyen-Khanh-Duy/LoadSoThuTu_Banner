using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class KsCauHoiTraLoi
{
    public long Id { get; set; }

    public long? IdcauHoi { get; set; }

    public long? IdcauTraLoi { get; set; }

    public virtual KsCauHoi? IdcauHoiNavigation { get; set; }

    public virtual KsCauTraLoi? IdcauTraLoiNavigation { get; set; }
}
