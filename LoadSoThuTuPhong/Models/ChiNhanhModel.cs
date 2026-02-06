using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoadSoThuTuPhong.Models
{
    [Table("DM_ChiNhanh")] 
    public class ChiNhanhModel
    {
        [Key]
        public long ID { get; set; }

        [StringLength(50)]
        public string? MaChiNhanh { get; set; }

        [StringLength(500)]
        public string? TenChiNhanh { get; set; }

        [StringLength(500)]
        public string? TenCoQuanChuyenMon { get; set; }

        [StringLength(500)]
        public string? DiaChi { get; set; }

        [StringLength(500)]
        public string? DiaChi2 { get; set; }

        [StringLength(500)]
        public string? DienThoai { get; set; }

        [StringLength(500)]
        public string? DienThoai2 { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [StringLength(500)]
        public string? Logo { get; set; }

        public bool? Active { get; set; }

        public long? IDNganHang { get; set; }

        [StringLength(50)]
        public string? MST { get; set; }

        [StringLength(50)]
        public string? SoTk { get; set; }

        [StringLength(50)]
        public string? ChuTk { get; set; }

        public int? STTBN { get; set; }

        public bool? KhoTong { get; set; }

        public long? IDThuTruongDonVi { get; set; }

        public long? IDThuQuy { get; set; }

        public long? IDKeToan { get; set; }

        [StringLength(50)]
        public string? MaCSKCB { get; set; }

        [StringLength(500)]
        public string? TenCSKCB { get; set; }

        [StringLength(500)]
        public string? APICongVan { get; set; }

        [StringLength(500)]
        public string? APISignPad { get; set; }

        public bool SinhVien { get; set; }
    }
}
