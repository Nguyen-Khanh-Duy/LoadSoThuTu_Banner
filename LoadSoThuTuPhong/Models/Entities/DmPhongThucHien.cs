using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmPhongThucHien
{
    public long Id { get; set; }

    public string? MaPhong { get; set; }

    public string? TenPhong { get; set; }

    public long? IdchiNhanh { get; set; }

    public bool? PhongKham { get; set; }

    public bool? PhongDieuTri { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<BenhNhanTheoNgay> BenhNhanTheoNgays { get; set; } = new List<BenhNhanTheoNgay>();

    public virtual DmChiNhanh? IdchiNhanhNavigation { get; set; }

    public virtual ICollection<QlVaoVien> QlVaoViens { get; set; } = new List<QlVaoVien>();

    public virtual ICollection<SttCapSoTheoPhong> SttCapSoTheoPhongs { get; set; } = new List<SttCapSoTheoPhong>();
}
