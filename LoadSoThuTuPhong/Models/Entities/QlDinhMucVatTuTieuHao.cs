using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlDinhMucVatTuTieuHao
{
    public long Id { get; set; }

    public long? Idhh { get; set; }

    public long? Iddvkt { get; set; }

    public double? SoLuong { get; set; }

    public virtual DmDichVuKyThuat? IddvktNavigation { get; set; }

    public virtual HhDmHangHoa? IdhhNavigation { get; set; }
}
