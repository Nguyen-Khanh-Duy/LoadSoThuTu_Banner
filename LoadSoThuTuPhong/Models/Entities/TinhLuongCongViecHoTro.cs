using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TinhLuongCongViecHoTro
{
    public long Id { get; set; }

    public string? MaCongViec { get; set; }

    public string? TenCongViec { get; set; }

    public double? DonGia { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<TinhLuongTongHopLuong> TinhLuongTongHopLuongs { get; set; } = new List<TinhLuongTongHopLuong>();
}
