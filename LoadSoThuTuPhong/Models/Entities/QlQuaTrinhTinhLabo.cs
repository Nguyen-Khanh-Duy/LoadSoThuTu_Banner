using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlQuaTrinhTinhLabo
{
    public long Id { get; set; }

    public long? Idkhdtct { get; set; }

    public long? Idbacsi { get; set; }

    public double? SoTienLabo { get; set; }

    public double? TyleLabo { get; set; }

    public DateOnly? Ngay { get; set; }

    public long? Idkip { get; set; }

    public long? Idcn { get; set; }

    public long? IdnhomCp { get; set; }
}
