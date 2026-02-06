using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlTuongQuanDvktQt
{
    public long Id { get; set; }

    public long? Idqt { get; set; }

    public long? Iddvkt { get; set; }

    public virtual DmDichVuKyThuat? IddvktNavigation { get; set; }

    public virtual TempQuyTrinhDieuTri? IdqtNavigation { get; set; }
}
