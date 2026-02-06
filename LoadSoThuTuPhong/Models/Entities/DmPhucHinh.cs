using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmPhucHinh
{
    public long Id { get; set; }

    public string? MaPhucHinh { get; set; }

    public string? TenPhucHinh { get; set; }

    public long? IddonViTinh { get; set; }

    public double? GiaChung { get; set; }

    public long? IdnhomDichVu { get; set; }

    public bool? Active { get; set; }

    public bool? Su { get; set; }

    public bool? KimLoai { get; set; }

    public long? IdThoiGian { get; set; }

    public virtual ICollection<DmPhucHinhNcc> DmPhucHinhNccs { get; set; } = new List<DmPhucHinhNcc>();

    public virtual DmThoiGian? IdThoiGianNavigation { get; set; }

    public virtual HhDmDonViTinh? IddonViTinhNavigation { get; set; }

    public virtual DmNhomDichVuKyThuat? IdnhomDichVuNavigation { get; set; }

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCts { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlPhieuLaBoCt> QlPhieuLaBoCts { get; set; } = new List<QlPhieuLaBoCt>();
}
