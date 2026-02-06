using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CskhDinhNghiaThamSo
{
    public long Id { get; set; }

    public string? MaThamSo { get; set; }

    public string? DinhNghiaThamSo { get; set; }

    public string? CauLenh { get; set; }

    public bool? Khac { get; set; }

    public bool? HangHoa { get; set; }

    public bool? Dvkt { get; set; }

    public bool? ThoiGian { get; set; }

    public virtual ICollection<CskhTemplateCt> CskhTemplateCts { get; set; } = new List<CskhTemplateCt>();
}
