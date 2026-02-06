using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class TemplateBenhAnRhm
{
    public long Id { get; set; }

    public string? Ma { get; set; }

    public string? MoTa { get; set; }

    public string? MacDinh { get; set; }

    public long? IdmauBenhAn { get; set; }

    public virtual DmMauBenhAn? IdmauBenhAnNavigation { get; set; }
}
