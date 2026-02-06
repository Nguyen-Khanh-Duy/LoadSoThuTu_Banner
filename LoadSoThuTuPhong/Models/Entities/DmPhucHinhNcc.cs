using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmPhucHinhNcc
{
    public long Id { get; set; }

    public long? IdnhaCungCap { get; set; }

    public long? IdphucHinh { get; set; }

    public double? DonGia { get; set; }

    public virtual HhDmNhaCungCap? IdnhaCungCapNavigation { get; set; }

    public virtual DmPhucHinh? IdphucHinhNavigation { get; set; }
}
