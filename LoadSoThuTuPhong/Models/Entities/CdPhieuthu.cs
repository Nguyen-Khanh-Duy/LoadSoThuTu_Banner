using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class CdPhieuthu
{
    public long Maso { get; set; }

    public string Loaihd { get; set; } = null!;

    public string? Quyen { get; set; }

    public string? Seri { get; set; }

    public double? Sohd { get; set; }

    public DateTime? Ngay { get; set; }

    public DateTime? Ngaylap { get; set; }

    public long? Idnv { get; set; }

    public int? Kip { get; set; }

    public string? Ptname { get; set; }

    public long Ptid { get; set; }

    public string? Diachi { get; set; }

    public string? Dienthoai { get; set; }

    public string? Mst { get; set; }

    public double? Thanhtien { get; set; }

    public double? Vat { get; set; }

    public long? Nguoilap { get; set; }

    public int? Tuan { get; set; }

    public int? Huy { get; set; }

    public int? Khoa { get; set; }

    public int? Ck { get; set; }

    public DateTime? Ngayck { get; set; }

    public long? Idbn { get; set; }

    public long? Idcn { get; set; }
}
