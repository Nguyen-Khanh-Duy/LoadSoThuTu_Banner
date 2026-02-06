using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlLichHenBenhNhan
{
    public long Id { get; set; }

    public long? IdbenhNhan { get; set; }

    public long? IdbenhNhanDuBi { get; set; }

    public long? IdvaoVien { get; set; }

    public DateOnly? NgayHen { get; set; }

    public TimeOnly? GioHen { get; set; }

    public long? IdbacSiHen { get; set; }

    public long? IdnoiDungKeHoach { get; set; }

    public long? IdlyDoHen { get; set; }

    public string? GhiChu { get; set; }

    public bool? DaDen { get; set; }

    public bool? KhongDen { get; set; }

    public virtual ICollection<BenhNhanTheoNgay> BenhNhanTheoNgays { get; set; } = new List<BenhNhanTheoNgay>();
}
