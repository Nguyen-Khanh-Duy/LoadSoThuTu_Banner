using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBoDungCuCt
{
    public long Id { get; set; }

    public long? IdhangHoa { get; set; }

    public long? IdboDungCu { get; set; }

    public long? IdtrangThai { get; set; }

    public double? Sl { get; set; }

    public virtual DmBoDungCu? IdboDungCuNavigation { get; set; }

    public virtual HhDmHangHoa? IdhangHoaNavigation { get; set; }

    public virtual DmTinhTrang? IdtrangThaiNavigation { get; set; }
}
