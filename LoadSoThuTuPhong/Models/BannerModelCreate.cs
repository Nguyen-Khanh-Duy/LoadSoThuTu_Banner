using Microsoft.AspNetCore.Mvc;

namespace LoadSoThuTuPhong.Models
{
    public class BannerModelCreate
    {
        public long? ID { get; set; }
        public string? TieuDe { get; set; }
        public string? HinhAnh { get; set; }
        public int? ThuTu { get; set; }
        public string? ViTri { get; set; }
        public string? NoiDung { get; set; }
        public string? DuongDan { get; set; }
        public long? IDChiNhanh { get; set; }
        public bool? HoatDong { get; set; }
        public IFormFile? HinhAnhFile { get; set; }
        public bool? RemoveImage { get; set; }
    }
}
