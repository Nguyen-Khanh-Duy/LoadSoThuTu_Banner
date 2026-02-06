using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoadSoThuTuPhong.Models
{
    [Table("DM_Banner")]
    public class BannerModel
    {
        [Key]
        public long ID { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; } = string.Empty;

        [StringLength(500)]
        [Display(Name = "Hình ảnh")]
        public string? HinhAnh { get; set; }

        [StringLength(1000)]
        [Display(Name = "Nội dung")]
        public string? NoiDung { get; set; } 

        [StringLength(50)]
        [Required]
        [Display(Name = "Vị trí")]
        public string ViTri { get; set; } = "left";

        [Display(Name = "Thứ tự")]
        public int ThuTu { get; set; } = 0;

        [Display(Name = "Hoạt động")]
        public bool HoatDong { get; set; } = true;

        [Display(Name = "Đường dẫn")]
        [StringLength(500)]
        public string? DuongDan { get; set; }  
        [Display(Name = "Ngày tạo")]
        public DateTime NgayTao { get; set; } = DateTime.Now;

        [Display(Name = "Ngày cập nhật")]
        public DateTime? NgayCapNhat { get; set; }

        [Display(Name = "Chi nhánh")]
        public long? IDChiNhanh { get; set; }

        [ForeignKey("IDChiNhanh")]
        public virtual ChiNhanhModel? ChiNhanh { get; set; } 
    }

}