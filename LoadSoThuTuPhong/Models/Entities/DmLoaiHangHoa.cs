using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmLoaiHangHoa
{
    public long Id { get; set; }

    public string? MaLoaiHang { get; set; }

    public string? TenLoaiHang { get; set; }

    public bool? NhomThuoc { get; set; }

    public bool? NhomVldemDuoc { get; set; }

    public bool? NhomVlkhongDemDuoc { get; set; }

    public bool? NhomVanPhongPham { get; set; }

    public bool? Active { get; set; }
}
