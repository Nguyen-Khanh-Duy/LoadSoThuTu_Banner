using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CskhLoaiCskh
{
    public long Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public long? TemplateId { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<ApiZlKetQuaZn> ApiZlKetQuaZns { get; set; } = new List<ApiZlKetQuaZn>();

    public virtual ICollection<CskhTemplateCt> CskhTemplateCts { get; set; } = new List<CskhTemplateCt>();

    public virtual DmTemplate? Template { get; set; }
}
