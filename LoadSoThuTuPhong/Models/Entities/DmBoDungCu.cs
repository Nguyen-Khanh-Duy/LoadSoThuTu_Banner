using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBoDungCu
{
    public long Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public double? Sl { get; set; }

    public DateTime? NgayTao { get; set; }

    public long? IdnhanVienTao { get; set; }

    public long? Idkhoa { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DmBoDungCuCt> DmBoDungCuCts { get; set; } = new List<DmBoDungCuCt>();

    public virtual DmNhanVien? IdnhanVienTaoNavigation { get; set; }

    public virtual ICollection<QlMuonTra> QlMuonTras { get; set; } = new List<QlMuonTra>();
}
