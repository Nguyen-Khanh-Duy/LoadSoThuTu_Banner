namespace LoadSoThuTuPhong.Models
{
    public class LoadLCDSoThuTuPhongModel
    {
        public string HoTenBenhNhan { get; set; }
        public int SoThuTu { get; set; }
        public int TrangThaiID { get; set; }
        public string TrangThai { get; set; }

        public string TenKhoa { get; set; }
        public string TenPhong { get; set; }

        public DateTime NgayHienTai { get; set; }
        public long IDChiNhanh { get; set; }
        public long IDKhoa { get; set; }
        public long IDPhongBuong { get; set; }
    }
}
