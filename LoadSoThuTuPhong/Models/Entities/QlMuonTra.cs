using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class QlMuonTra
{
    public long Id { get; set; }

    public long? IdvaoVien { get; set; }

    public long? IdnhanVienMuon { get; set; }

    public DateTime? NgayMuon { get; set; }

    public DateTime? NgayTraDuKien { get; set; }

    public long? IdboCongCu { get; set; }

    public DateTime? NgayTra { get; set; }

    public long? IdnhanVienTra { get; set; }

    public long? IdbntheoNgay { get; set; }

    public virtual BenhNhanTheoNgay? IdbntheoNgayNavigation { get; set; }

    public virtual DmBoDungCu? IdboCongCuNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienMuonNavigation { get; set; }

    public virtual DmNhanVien? IdnhanVienTraNavigation { get; set; }

    public virtual QlVaoVien? IdvaoVienNavigation { get; set; }
}
