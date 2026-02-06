using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HtPhanQuyen
{
    public long Id { get; set; }

    public long? Idnv { get; set; }

    public long? Idcn { get; set; }

    public long? Idvt { get; set; }

    public long? IdsinhVien { get; set; }

    public bool? Active { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmNhanVien? IdnvNavigation { get; set; }

    public virtual DmSinhVien? IdsinhVienNavigation { get; set; }

    public virtual DmVaiTro? IdvtNavigation { get; set; }
}
