using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class ApiZlAccesstoken
{
    public long Id { get; set; }

    public string? AccessToken { get; set; }

    public string? RefreshToken { get; set; }

    public string? ExpireIn { get; set; }

    public DateTime? NgayNhan { get; set; }

    public DateTime? RefreshCreateTime { get; set; }
}
