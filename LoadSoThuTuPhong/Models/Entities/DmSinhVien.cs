using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class DmSinhVien
{
    public long Id { get; set; }

    public long? Idlop { get; set; }

    public string? MaSinhVien { get; set; }

    public string? TenSinhVien { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public long? IdgioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? TaiKhoan { get; set; }

    public string? MatKhau { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<HtPhanQuyen> HtPhanQuyens { get; set; } = new List<HtPhanQuyen>();

    public virtual DmGioiTinh? IdgioiTinhNavigation { get; set; }

    public virtual DmLopHoc? IdlopNavigation { get; set; }

    public virtual ICollection<QlKeHoachDieuTri> QlKeHoachDieuTris { get; set; } = new List<QlKeHoachDieuTri>();

    public virtual ICollection<QlKhamTongQuat> QlKhamTongQuats { get; set; } = new List<QlKhamTongQuat>();

    public virtual ICollection<QlPhieuDieuTri> QlPhieuDieuTris { get; set; } = new List<QlPhieuDieuTri>();
}
