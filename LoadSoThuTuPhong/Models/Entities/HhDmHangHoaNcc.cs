using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmHangHoaNcc
{
    public long Id { get; set; }

    public long? Idhh { get; set; }

    public long? Idncc { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }

    public virtual HhDmNhaCungCap? IdnccNavigation { get; set; }
}
