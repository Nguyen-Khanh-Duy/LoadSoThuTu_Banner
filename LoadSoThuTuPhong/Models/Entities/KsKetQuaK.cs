using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class KsKetQuaK
{
    public long Id { get; set; }

    public long? Idbn { get; set; }

    public long? Idvv { get; set; }

    public string? TenBn { get; set; }

    public string? Sdt { get; set; }

    public long? IdcauHoi { get; set; }

    public long? IdcauTraLoi { get; set; }

    public string? CauTraLoi { get; set; }

    public DateTime? NgayKhaoSat { get; set; }

    public virtual KsCauHoi? IdcauHoiNavigation { get; set; }

    public virtual KsCauTraLoi? IdcauTraLoiNavigation { get; set; }
}
