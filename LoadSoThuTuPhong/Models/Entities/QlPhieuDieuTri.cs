using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlPhieuDieuTri
{
    public long Id { get; set; }

    public string? SoPhieu { get; set; }

    public DateTime? Ngay { get; set; }

    public long? IdgioHen { get; set; }

    public long? IdchiNhanh { get; set; }

    public long? IdbenhNhan { get; set; }

    public long? IdbacSi { get; set; }

    public long? IdtroThu { get; set; }

    public long? IdhoLy { get; set; }

    public long? IdlyDoHen { get; set; }

    public string? LyDoKhac { get; set; }

    public long? Idkhdtct { get; set; }

    public long? IdketQuaDt { get; set; }

    public string? MoTa { get; set; }

    public long? IdsinhVien { get; set; }

    public long? IdquyTrinhCt { get; set; }

    public bool? DangLam { get; set; }

    public bool? HoanTat { get; set; }

    public long? Idkip { get; set; }

    public virtual DmNhanVien? IdbacSiNavigation { get; set; }

    public virtual DmBenhNhan? IdbenhNhanNavigation { get; set; }

    public virtual DmKhungGioHen? IdgioHenNavigation { get; set; }

    public virtual DmKetQuaDieuTri? IdketQuaDtNavigation { get; set; }

    public virtual QlKeHoachDieuTriCt? IdkhdtctNavigation { get; set; }

    public virtual DmLyDoHen? IdlyDoHenNavigation { get; set; }

    public virtual TempQuyTrinhDieuTriCt? IdquyTrinhCtNavigation { get; set; }

    public virtual DmSinhVien? IdsinhVienNavigation { get; set; }

    public virtual DmNhanVien? IdtroThuNavigation { get; set; }
}
