using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlLaBo
{
    public long Id { get; set; }

    public long? IdnoiDungKeHoach { get; set; }

    public long? IdnhaCungCap { get; set; }

    public long? IdphucHinh { get; set; }

    public long IdmaMau { get; set; }

    public DateTime? NgayDat { get; set; }

    public double? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public double? TileGiam { get; set; }

    public long? IdnhanVienTao { get; set; }

    public DateTime? NgayNhanDuKien { get; set; }

    public long? IdnhanVienNhan { get; set; }

    public DateTime? NgayChinhThucNhan { get; set; }

    public bool? DaNhan { get; set; }
}
