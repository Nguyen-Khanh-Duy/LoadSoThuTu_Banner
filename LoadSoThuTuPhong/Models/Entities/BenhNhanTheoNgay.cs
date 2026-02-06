using System;
using System.Collections.Generic;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class BenhNhanTheoNgay
{
    public long Id { get; set; }

    public long? IdbenhNhan { get; set; }

    public long? Idcn { get; set; }

    public DateTime? NgayGioDen { get; set; }

    public long? IdlichHen { get; set; }

    public long? IdphongBuong { get; set; }

    public bool? DaXuLy { get; set; }

    public bool? ChiDinh { get; set; }

    public bool? ThuNgan { get; set; }

    public bool? DieuTri { get; set; }

    public bool? Kham { get; set; }

    public long? IdbacSiHienTai { get; set; }

    public virtual DmBenhNhan? IdbenhNhanNavigation { get; set; }

    public virtual DmChiNhanh? IdcnNavigation { get; set; }

    public virtual QlLichHenBenhNhan? IdlichHenNavigation { get; set; }

    public virtual DmPhongThucHien? IdphongBuongNavigation { get; set; }

    public virtual ICollection<QlMuonTra> QlMuonTras { get; set; } = new List<QlMuonTra>();

    public virtual ICollection<SttCapSoTheoBacSi> SttCapSoTheoBacSis { get; set; } = new List<SttCapSoTheoBacSi>();

    public virtual ICollection<SttCapSoTheoPhong> SttCapSoTheoPhongs { get; set; } = new List<SttCapSoTheoPhong>();
}
