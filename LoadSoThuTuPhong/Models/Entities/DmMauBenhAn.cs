using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmMauBenhAn
{
    public long Id { get; set; }

    public long? IdbenhAn { get; set; }

    public string? TenMauBenhAn { get; set; }

    public virtual DmBenhAn? IdbenhAnNavigation { get; set; }

    public virtual ICollection<TemplateBenhAnRhmngoaiTru> TemplateBenhAnRhmngoaiTrus { get; set; } = new List<TemplateBenhAnRhmngoaiTru>();

    public virtual ICollection<TemplateBenhAnRhm> TemplateBenhAnRhms { get; set; } = new List<TemplateBenhAnRhm>();
}
