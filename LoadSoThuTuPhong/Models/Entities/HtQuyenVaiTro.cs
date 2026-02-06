using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtQuyenVaiTro
{
    public long Id { get; set; }

    public long? IdvaiTro { get; set; }

    public long? IdchucNang { get; set; }

    public bool? Xem { get; set; }

    public bool? Them { get; set; }

    public bool? Sua { get; set; }

    public bool? Xoa { get; set; }

    public bool? Xuat { get; set; }

    public bool? CaNhan { get; set; }

    public virtual HtChucNang? IdchucNangNavigation { get; set; }

    public virtual DmVaiTro? IdvaiTroNavigation { get; set; }
}
