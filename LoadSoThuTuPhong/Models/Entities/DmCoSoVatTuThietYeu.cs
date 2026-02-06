using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmCoSoVatTuThietYeu
{
    public long Id { get; set; }

    public long? Idhh { get; set; }

    public long? Idcn { get; set; }

    public double? CoSo { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }
}
