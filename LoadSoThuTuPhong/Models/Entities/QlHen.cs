using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlHen
{
    public long Id { get; set; }

    public long? Idcn { get; set; }

    public long? IdvaoVien { get; set; }

    public long? Idbs { get; set; }

    public long? IdthoiGian { get; set; }

    public long? IdlyDoHen { get; set; }

    public long? Idbn { get; set; }

    public DateTime? Ngay { get; set; }

    public string? LyDoKhac { get; set; }

    public string? TenBn { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public bool? DaDen { get; set; }

    public virtual DmBenhNhan? IdbnNavigation { get; set; }

    public virtual DmNhanVien? IdbsNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual DmLyDoHen? IdlyDoHenNavigation { get; set; }

    public virtual DmThoiGianHen? IdthoiGianNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
