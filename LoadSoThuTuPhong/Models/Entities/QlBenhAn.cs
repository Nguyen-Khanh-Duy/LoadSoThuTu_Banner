using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlBenhAn
{
    public long Id { get; set; }

    public long? IdvaoVien { get; set; }

    public string? MaLuuTru { get; set; }

    public long? IdbenhAn { get; set; }

    public long? IdnganKe { get; set; }

    public DateTime? NgayLuuHoSo { get; set; }

    public string? Data { get; set; }

    public virtual DmBenhAn? IdbenhAnNavigation { get; set; }

    public virtual HhDmNganKe? IdnganKeNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
