using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlToaThuocMauCt
{
    public long Id { get; set; }

    public long? IdmauToa { get; set; }

    public double? SoNgay { get; set; }

    public long? IdhangHoa { get; set; }

    public string? Sang { get; set; }

    public string? Trua { get; set; }

    public string? Chieu { get; set; }

    public string? Toi { get; set; }

    public double? TongSoLuong { get; set; }

    public string? CachDungKhac { get; set; }

    public string? LieuDung { get; set; }

    public virtual HhDmHangHoa? IdhangHoaNavigation { get; set; }

    public virtual QlToaThuocMau? IdmauToaNavigation { get; set; }
}
