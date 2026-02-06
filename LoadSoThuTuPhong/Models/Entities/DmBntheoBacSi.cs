using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBntheoBacSi
{
    public long Id { get; set; }

    public long? IdnhanVien { get; set; }

    public long? Idbn { get; set; }

    public long? IdvaoVien { get; set; }

    public bool? Them { get; set; }

    public bool? Active { get; set; }

    public virtual DmBenhNhan? IdbnNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
