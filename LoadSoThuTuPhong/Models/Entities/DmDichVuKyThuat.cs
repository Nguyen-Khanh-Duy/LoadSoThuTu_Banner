using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmDichVuKyThuat
{
    public long Id { get; set; }

    public long IdnhomDichVu { get; set; }

    public string MaDichVu { get; set; } = null!;

    public string TenDichVu { get; set; } = null!;

    public string? TenDichVuTa { get; set; }

    public long? IddonViTinh { get; set; }

    public double? DonGia { get; set; }

    public long? IdthoiGianBaoHanh { get; set; }

    public long? IdthoiGianChamSocSauDieuTri { get; set; }

    public long? IdthoiGianChamSocDinhKy { get; set; }

    public string? MaQuyTrinh { get; set; }

    public bool? Active { get; set; }

    public double? ThueVat { get; set; }

    public bool? PhuImplant { get; set; }

    public long? IdnhomChiPhi { get; set; }

    public string? Stt { get; set; }

    public string? Stttt14 { get; set; }

    public string? Loaittpt { get; set; }

    public virtual ICollection<DmDichVuKyThuatGium> DmDichVuKyThuatGia { get; set; } = new List<DmDichVuKyThuatGium>();

    public virtual ICollection<DmDichVuKyThuatSoLanDung> DmDichVuKyThuatSoLanDungs { get; set; } = new List<DmDichVuKyThuatSoLanDung>();

    public virtual ICollection<DmTiLeHoaHong> DmTiLeHoaHongs { get; set; } = new List<DmTiLeHoaHong>();

    public virtual HhDmDonViTinh? IddonViTinhNavigation { get; set; }

    public virtual DmNhomChiPhi? IdnhomChiPhiNavigation { get; set; }

    public virtual DmNhomDichVuKyThuat IdnhomDichVuNavigation { get; set; } = null!;

    public virtual DmThoiGian? IdthoiGianBaoHanhNavigation { get; set; }

    public virtual DmThoiGian? IdthoiGianChamSocDinhKyNavigation { get; set; }

    public virtual DmThoiGian? IdthoiGianChamSocSauDieuTriNavigation { get; set; }

    public virtual ICollection<QlChiDinh> QlChiDinhs { get; set; } = new List<QlChiDinh>();

    public virtual ICollection<QlDinhMucVatTuTieuHao> QlDinhMucVatTuTieuHaos { get; set; } = new List<QlDinhMucVatTuTieuHao>();

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCts { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlTuongQuanDvktQt> QlTuongQuanDvktQts { get; set; } = new List<QlTuongQuanDvktQt>();
}
