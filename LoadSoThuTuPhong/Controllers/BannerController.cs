using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using LoadSoThuTuPhong.Models;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using LoadSoThuTuPhong.Models.Entities;
using LoadSoThuTuPhong.Service.IS;

namespace LoadSoThuTuPhong.Controllers
{
    [Route("banner")]
    public class BannerController : Controller
    {
        private readonly Context0306 _dbService;
        private readonly IWebHostEnvironment _env;
        private readonly HisContext _hisContext;
        private readonly IFtpService _ftpService;
        private readonly ILogger<BannerController> _logger;

        public BannerController(Context0306 dbService, IWebHostEnvironment env, HisContext context, IFtpService ftpService, ILogger<BannerController> logger)
        {
            _dbService = dbService;
            _env = env;
            _hisContext = context;
            _ftpService = ftpService;
            _logger = logger;
        }
        [HttpGet]
        [Route("index")]
        public async Task<IActionResult> Index(int page = 1, int pageSize = 10, long? editId = null)
        {
            var totalBanners = await _dbService.BannerModels.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalBanners / pageSize);

            var banners = await _dbService.BannerModels
                .Include(b => b.ChiNhanh)
                .OrderBy(b => b.ViTri)
                .ThenBy(b => b.ThuTu)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var thongTinChiNhanh = _hisContext.DmChiNhanhs.Select(s => new
            {
                id = s.Id,
                tenCSKCB = s.TenCskcb,
            }).ToList();

            // Lấy banner đang chỉnh sửa (nếu có)
            BannerModel editingBanner = null;
            bool isEdit = false;

            if (editId.HasValue)
            {
                editingBanner = await _dbService.BannerModels
                    .Include(b => b.ChiNhanh)
                    .FirstOrDefaultAsync(b => b.ID == editId.Value);

                if (editingBanner != null)
                {
                    isEdit = true;
                }
            }

            ViewBag.thongTinDN = thongTinChiNhanh;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalItems = totalBanners;
            ViewBag.EditingBanner = editingBanner;
            ViewBag.IsEdit = isEdit;

            return View("Index", banners); // Luôn trả về view Index
        }

        [HttpGet]
        [Route("edit/{id:long}")]
        public async Task<IActionResult> Edit(long id)
        {
            // Chuyển hướng về Index với tham số editId
            return RedirectToAction("Index", new { editId = id });
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromForm] BannerModelCreate banner)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (banner.HinhAnhFile != null)
                banner.HinhAnh = await UploadFile(banner.HinhAnhFile);

            var entity = new BannerModel
            {
                TieuDe = banner.TieuDe,
                NoiDung = banner.NoiDung,
                ViTri = banner.ViTri ?? "",
                ThuTu = banner.ThuTu ?? 0,
                HoatDong = banner.HoatDong ?? true,
                DuongDan = banner.DuongDan,
                HinhAnh = banner.HinhAnh,
                IDChiNhanh = banner.IDChiNhanh,
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now
            };

            _dbService.BannerModels.Add(entity);
            await _dbService.SaveChangesAsync();

            return Ok(new { success = true });
        }

        [HttpPost]
        [Route("edit/{id:long}")]
        public async Task<IActionResult> Edit(long id, [FromForm] BannerModelEdit model)
        {
            if (id != model.ID)
                return BadRequest();

            var banner = await _dbService.BannerModels.FindAsync(id);
            if (banner == null)
                return NotFound();

            banner.TieuDe = model.TieuDe;
            banner.NoiDung = model.NoiDung;
            banner.ViTri = model.ViTri;
            banner.ThuTu = model.ThuTu ?? 0;
            banner.DuongDan = model.DuongDan;
            banner.HoatDong = model.HoatDong;
            banner.IDChiNhanh = model.IDChiNhanh;
            banner.NgayCapNhat = DateTime.Now;

            if (model.RemoveImage)
            {
                DeleteFile(banner.HinhAnh);
                banner.HinhAnh = null;
            }
            else if (model.HinhAnhFile != null && model.HinhAnhFile.Length > 0)
            {
                DeleteFile(banner.HinhAnh);
                banner.HinhAnh = await UploadFile(model.HinhAnhFile);
            }

            await _dbService.SaveChangesAsync();

            return Ok(new { success = true });
        }

        [HttpGet]
        [Route("api/get-active-banners")]
        public async Task<IActionResult> GetActiveBanners([FromQuery] long? idChiNhanh = null)
        {
            try
            {
                idChiNhanh ??= 1;

                var banners = await _hisContext.DmBanners
                    .Where(b => b.HoatDong)
                    .Where(b => b.IdchiNhanh == null || b.IdchiNhanh == idChiNhanh)
                    .OrderBy(b => b.ViTri)
                    .ThenBy(b => b.ThuTu)
                    .Select(b => new
                    {
                        id = b.Id,
                        tieuDe = b.TieuDe,
                        hinhAnh = b.HinhAnh,
                        duongDan = b.DuongDan,
                        viTri = b.ViTri,
                        hoatDong = b.HoatDong,
                        thuTu = b.ThuTu,
                        idChiNhanh = b.IdchiNhanh
                    })
                    .ToListAsync();

                return Ok(banners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/get-banner/{id:long}")]
        public async Task<IActionResult> GetBannerData(long id)
        {
            try
            {
                var banner = await _dbService.BannerModels
                    .Include(b => b.ChiNhanh)
                    .FirstOrDefaultAsync(b => b.ID == id);

                if (banner == null)
                {
                    return NotFound(new { success = false, message = "Banner không tồn tại" });
                }

                return Ok(new
                {
                    success = true,
                    data = new
                    {
                        id = banner.ID,
                        tieuDe = banner.TieuDe,
                        hinhAnh = banner.HinhAnh,
                        viTri = banner.ViTri,
                        thuTu = banner.ThuTu,
                        noiDung = banner.NoiDung,
                        duongDan = banner.DuongDan,
                        hoatDong = banner.HoatDong,
                        idChiNhanh = banner.IDChiNhanh,
                        chiNhanh = banner.ChiNhanh != null ? new
                        {
                            id = banner.ChiNhanh.ID,
                            tenCSKCB = banner.ChiNhanh.TenCSKCB
                        } : null
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        [Route("delete/{id:long}")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banner = await _dbService.BannerModels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }

        [HttpPost]
        [Route("delete/{id:long}")]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var banner = await _dbService.BannerModels.FindAsync(id);

            if (!string.IsNullOrEmpty(banner.HinhAnh))
            {
                DeleteFile(banner.HinhAnh);
            }

            _dbService.BannerModels.Remove(banner);
            await _dbService.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Route("uploadimage")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Json(new { success = false, message = "Không có file" });

            try
            {
                var filePath = await UploadFile(file);
                return Json(new
                {
                    success = true,
                    path = filePath,
                    fileName = Path.GetFileName(filePath)
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("deleteimage")]
        public IActionResult DeleteImage(string path)
        {
            try
            {
                DeleteFile(path);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        // ========== CÁC PHƯƠNG THỨC HỖ TRỢ ==========

        private bool BannerExists(long id)
        {
            return _dbService.BannerModels.Any(e => e.ID == id);
        }

        private async Task<string> UploadFile(IFormFile file)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
            var extension = Path.GetExtension(file.FileName).ToLower();

            if (!allowedExtensions.Contains(extension))
                throw new Exception("Định dạng file không hợp lệ. Chỉ chấp nhận: " +
                    string.Join(", ", allowedExtensions));

            var fileName = $"{Guid.NewGuid()}{extension}";
            var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads", "banners");

            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var filePath = Path.Combine(uploadsFolder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return $"/uploads/banners/{fileName}";
        }

        private void DeleteFile(string path)
        {
            if (string.IsNullOrEmpty(path)) return;

            var physicalPath = Path.Combine(_env.WebRootPath, path.TrimStart('/'));

            if (System.IO.File.Exists(physicalPath))
            {
                System.IO.File.Delete(physicalPath);
            }
        }

        [HttpPost]
        [Route("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus(long id, [FromBody] ToggleStatusModel model)
        {
            var banner = await _dbService.BannerModels.FindAsync(id);
            if (banner == null)
            {
                return NotFound();
            }

            banner.HoatDong = model.HoatDong;
            banner.NgayCapNhat = DateTime.Now;

            _dbService.Update(banner);
            await _dbService.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("ftp/download")]
        public async Task<IActionResult> DownloadFile([FromQuery] string path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    return BadRequest(new { message = "Path is required" });
                }

                var fileBytes = await _ftpService.GetFileBytesByPathAsync(path);

                if (fileBytes == null || fileBytes.Length == 0)
                {
                    return NotFound(new { message = "File not found or empty" });
                }

                var extension = Path.GetExtension(path).ToLower();
                var contentType = extension switch
                {
                    ".jpg" or ".jpeg" => "image/jpeg",
                    ".png" => "image/png",
                    ".gif" => "image/gif",
                    ".svg" => "image/svg+xml",
                    ".pdf" => "application/pdf",
                    ".txt" => "text/plain",
                    _ => "application/octet-stream"
                };

                var fileName = Path.GetFileName(path);

                return File(fileBytes, contentType, fileName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error downloading file from FTP");
                return StatusCode(500, new { message = "Internal server error" });
            }

        } 

        public class ToggleStatusModel
        {
            public bool HoatDong { get; set; }
        }
    }
    public class BannerModelEdit
    {
        public long ID { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string ViTri { get; set; }
        public int? ThuTu { get; set; }
        public string DuongDan { get; set; }
        public bool HoatDong { get; set; }
        public long? IDChiNhanh { get; set; }
        public IFormFile HinhAnhFile { get; set; }
        public bool RemoveImage { get; set; }
    }
}