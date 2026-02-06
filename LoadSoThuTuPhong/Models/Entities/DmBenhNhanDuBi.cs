using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmBenhNhanDuBi
{
    public long Id { get; set; }

    public string MaBenhNhan { get; set; } = null!;

    public string TenBenhNhan { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public int NamSinh { get; set; }

    public long IdgioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public long? Idtinh { get; set; }

    public long? Idquan { get; set; }

    public long? Idpx { get; set; }

    public long? IdquocGia { get; set; }

    public long? IddanToc { get; set; }

    public string DienThoai { get; set; } = null!;

    public string? Email { get; set; }

    public long? IdngheNghiep { get; set; }

    public long IdnguonTin { get; set; }

    public long? IdloaiBenhNhan { get; set; }

    public DateOnly? NgayDenLanDau { get; set; }

    public long? IdnhanVienCapNhat { get; set; }

    public long IdchiNhanh { get; set; }

    public string? Tkzalo { get; set; }

    public string? TkfaceBook { get; set; }

    public string? Tktelegram { get; set; }

    public bool? Active { get; set; }

    public virtual DmChiNhanh IdchiNhanhNavigation { get; set; } = null!;

    public virtual DmDanToc? IddanTocNavigation { get; set; }

    public virtual DmGioiTinh IdgioiTinhNavigation { get; set; } = null!;

    public virtual DmLoaiBenhNhan? IdloaiBenhNhanNavigation { get; set; }

    public virtual DmNgheNghiep? IdngheNghiepNavigation { get; set; }

    public virtual DmNguonTin IdnguonTinNavigation { get; set; } = null!;

    public virtual DmNhanVien? IdnhanVienCapNhatNavigation { get; set; }

    public virtual DmXaCuTru? IdpxNavigation { get; set; }

    public virtual DmQuanCuTru? IdquanNavigation { get; set; }

    public virtual DmQuocGium? IdquocGiaNavigation { get; set; }

    public virtual DmTinhCuTru? IdtinhNavigation { get; set; }
}
