using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HhDmDonViTinh
{
    public long Id { get; set; }

    public string MaDvt { get; set; } = null!;

    public string? TenDvt { get; set; }

    public int? Nvtao { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? Nvsua { get; set; }

    public DateTime? NgaySua { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DmDichVuKyThuat> DmDichVuKyThuats { get; set; } = new List<DmDichVuKyThuat>();

    public virtual ICollection<DmPhucHinh> DmPhucHinhs { get; set; } = new List<DmPhucHinh>();

    public virtual ICollection<HhDmHangHoa> HhDmHangHoas { get; set; } = new List<HhDmHangHoa>();

    public virtual ICollection<HhPhieuNhapCcdcCt> HhPhieuNhapCcdcCts { get; set; } = new List<HhPhieuNhapCcdcCt>();

    public virtual ICollection<HhPhieuNhapCt> HhPhieuNhapCts { get; set; } = new List<HhPhieuNhapCt>();

    public virtual ICollection<HhPhieuXuatCt> HhPhieuXuatCts { get; set; } = new List<HhPhieuXuatCt>();

    public virtual ICollection<HhPhieuXuatThanhLyCt> HhPhieuXuatThanhLyCts { get; set; } = new List<HhPhieuXuatThanhLyCt>();

    public virtual ICollection<QlPhieuDeNghiCapHangCt> QlPhieuDeNghiCapHangCts { get; set; } = new List<QlPhieuDeNghiCapHangCt>();

    public virtual ICollection<QlPhieuDuTruCt> QlPhieuDuTruCts { get; set; } = new List<QlPhieuDuTruCt>();
}
