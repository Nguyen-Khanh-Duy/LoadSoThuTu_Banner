using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class SttCapSoTheoPhong
{
    public long Id { get; set; }

    public DateOnly? Ngay { get; set; }

    public long? IdphongBuong { get; set; }

    public long? IdbnTheoNgay { get; set; }

    public int? SoThuTu { get; set; }

    public bool? DaXuLy { get; set; }

    public virtual BenhNhanTheoNgay? IdbnTheoNgayNavigation { get; set; }

    public virtual DmPhongThucHien? IdphongBuongNavigation { get; set; }
}
