using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlKhamTongQuat
{
    public long Id { get; set; }

    public string? SoPhieuKham { get; set; }

    public long? IdvaoVien { get; set; }

    public DateTime? NgayKham { get; set; }

    public long? IdbacSiKham { get; set; }

    public bool? ChayMauLau { get; set; }

    public bool? PhanUngThuoc { get; set; }

    public bool? CaoHuyetAp { get; set; }

    public bool? BenhTimMach { get; set; }

    public bool? BenhTieuDuong { get; set; }

    public bool? BenhBenhPhoi { get; set; }

    public bool? BenhTuyenNhiem { get; set; }

    public bool? KhongBenhLy { get; set; }

    public string? Mach { get; set; }

    public string? NhietDo { get; set; }

    public string? HuyetAp { get; set; }

    public bool? KhnhaChu { get; set; }

    public bool? KhtramRang { get; set; }

    public bool? KhchuaTuy { get; set; }

    public bool? KhnhoRang { get; set; }

    public bool? Khphcd { get; set; }

    public bool? Khphtl { get; set; }

    public bool? Khchrm { get; set; }

    public bool? KhphongNgua { get; set; }

    public bool? KhtayTrang { get; set; }

    public bool? Khimp { get; set; }

    public long? IdsinhVien { get; set; }

    public string? NhanXet { get; set; }

    public string? BenhKhac { get; set; }

    public string? LyDoDenKham { get; set; }

    public string? ChieuCao { get; set; }

    public string? CanNang { get; set; }

    public string? Bmi { get; set; }

    public virtual DmNhanVien? IdbacSiKhamNavigation { get; set; }

    public virtual DmSinhVien? IdsinhVienNavigation { get; set; }
}
