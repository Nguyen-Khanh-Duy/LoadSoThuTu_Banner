using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class ApiZlKetQuaZn
{
    public long Id { get; set; }

    public long? IdbenhNhan { get; set; }

    public long? IdvaoVien { get; set; }

    public int? Error { get; set; }

    public string? Message { get; set; }

    public string? MsgId { get; set; }

    public DateTime? SentTime { get; set; }

    public int? SendingMode { get; set; }

    public long? DailyQuota { get; set; }

    public long? RemainingQuota { get; set; }

    public long? Loai { get; set; }

    public virtual DmBenhNhan? IdbenhNhanNavigation { get; set; }

    public virtual CskhLoaiCskh? LoaiNavigation { get; set; }
}
