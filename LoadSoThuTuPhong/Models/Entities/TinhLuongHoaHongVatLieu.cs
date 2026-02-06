using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TinhLuongHoaHongVatLieu
{
    public long Id { get; set; }

    public long? Idhh { get; set; }

    public double? TyLeHoaHong { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }
}
