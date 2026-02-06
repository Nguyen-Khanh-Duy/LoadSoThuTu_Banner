using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmNhaCungCap
{
    public long Id { get; set; }

    public string MaNcc { get; set; } = null!;

    public string? TenNcc { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? GhiChu { get; set; }

    public long? IdnganHang { get; set; }

    public string? SoTk { get; set; }

    public string? ChuTaiKhoan { get; set; }

    public DateOnly? NgayChotNo { get; set; }

    public double? TienChotNo { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public bool? VatLieu { get; set; }

    public bool? PhucHinh { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DmPhucHinhNcc> DmPhucHinhNccs { get; set; } = new List<DmPhucHinhNcc>();

    public virtual ICollection<HhDmHangHoaNcc> HhDmHangHoaNccs { get; set; } = new List<HhDmHangHoaNcc>();

    public virtual ICollection<HhPhieuNhapCcdc> HhPhieuNhapCcdcs { get; set; } = new List<HhPhieuNhapCcdc>();

    public virtual ICollection<HhPhieuNhapKho> HhPhieuNhapKhos { get; set; } = new List<HhPhieuNhapKho>();

    public virtual HhDmNganHang? IdnganHangNavigation { get; set; }

    public virtual ICollection<QlKeHoachDieuTriCt> QlKeHoachDieuTriCts { get; set; } = new List<QlKeHoachDieuTriCt>();

    public virtual ICollection<QlPhieuTraNo> QlPhieuTraNos { get; set; } = new List<QlPhieuTraNo>();
}
