using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TinhLuongDinhMucLaboTinhLuong
{
    public long Id { get; set; }

    public double? SoLuongMin { get; set; }

    public double? SoLuongMax { get; set; }

    public double? DonGia { get; set; }

    public bool? Su { get; set; }

    public bool? KimLoai { get; set; }

    public long? IdChiNhanh { get; set; }

    public virtual DmChiNhanh? IdChiNhanhNavigation { get; set; }
}
