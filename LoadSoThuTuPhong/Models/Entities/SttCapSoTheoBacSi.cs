using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class SttCapSoTheoBacSi
{
    public long Id { get; set; }

    public DateOnly? Ngay { get; set; }

    public long? IdbacSiHienTai { get; set; }

    public long? IdbnTheoNgay { get; set; }

    public int? SoThuTu { get; set; }

    public bool? DaXuLy { get; set; }

    public virtual DmNhanVien? IdbacSiHienTaiNavigation { get; set; }

    public virtual BenhNhanTheoNgay? IdbnTheoNgayNavigation { get; set; }
}
