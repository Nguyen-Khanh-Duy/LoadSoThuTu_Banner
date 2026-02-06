
using LoadSoThuTuPhong.Models;
using LoadSoThuTuPhong.Service.IS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace LoadSoThuTuPhong.Controllers

{
    [Route("load_so_thu_tu_phong")]
    public class LoadLCDSoThuTuController : Controller
    {
      
        private readonly LoadSoThuTuPhongInterface _service;
        private readonly Context0306 _dbService;
        private readonly IWebHostEnvironment _env;

        public LoadLCDSoThuTuController(LoadSoThuTuPhongInterface service, Context0306 dbService, IWebHostEnvironment env)
        {
            _service = service;
            _dbService = dbService;
            _env = env;
        }

        public async Task<IActionResult> Index(long? idChiNhanh)
        {
           
            ViewBag.quyenVaiTro = new
            {
                Them = true,
                Sua = true,
                Xoa = true,
                Xuat = true,
                CaNhan = true,
                Xem = true,
            };

            if (!idChiNhanh.HasValue || idChiNhanh == 0)
            {
                idChiNhanh = GetIdcnFromBienChung();
            }
            // Truy vấn EF Core
            var thongTin = await _dbService.Set<ChiNhanhModel>()
                .FirstOrDefaultAsync(x => x.ID == idChiNhanh);

            ViewData["HideSpecificMenus"] = true;
            ViewBag.DoanhNghiep = thongTin;

            return View(thongTin);
        }
        private long GetIdcnFromBienChung()
        {
            try
            {
                var bienChungPath = Path.Combine(_env.WebRootPath, "dist", "js", "BienChung.js");

                if (System.IO.File.Exists(bienChungPath))
                {
                    var jsContent = System.IO.File.ReadAllText(bienChungPath);

                    // Tìm giá trị _idcn bằng regex
                    var match = Regex.Match(jsContent, @"var _idcn\s*=\s*(\d+);");
                    if (match.Success && long.TryParse(match.Groups[1].Value, out long idcn))
                    {
                        return idcn;
                    }

                    // Hoặc tìm theo cách khác nếu định dạng khác
                    match = Regex.Match(jsContent, @"_idcn\s*:\s*(\d+)");
                    if (match.Success && long.TryParse(match.Groups[1].Value, out idcn))
                    {
                        return idcn;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                Console.WriteLine($"Lỗi khi đọc BienChung.js: {ex.Message}");
            }

            return 2; // Giá trị mặc định nếu không đọc được
        }

         [HttpPost("api/lcd-data")]
        public async Task<IActionResult> GetLCDData(long IdPhongBuong, long IdChiNhanh)
        {
            var result = await _service.FilterSoThuTuPhong(IdPhongBuong, IdChiNhanh);

            if (!result.Success)
                return Json(new { success = false });

            var data = ((dynamic)result.Data).Data;

            // Cast data to IEnumerable<dynamic> before using LINQ
            var formatted = ((IEnumerable<dynamic>)data).Select(x => new
            {
                soThuTu = x.SoThuTu,
                tenBenhNhan = x.HoTenBenhNhan,
                trangThai = x.TrangThaiID,
                phong = x.TenPhong,
                khoa = x.TenKhoa
            });

            return Json(new
            {
                success = true,
                data = formatted
            });
        }
        [HttpGet("api/khoa")]
        public async Task<IActionResult> GetKhoa(long idChiNhanh)
        {
            var list = new List<object>();

            using var conn = _dbService.Database.GetDbConnection();
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "dbo.S00_LCDSoThuTu";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@IDChiNhanh", idChiNhanh));
            cmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@IDKhoa", DBNull.Value));
            cmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@IDPhongBuong", DBNull.Value));

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new
                {
                    id = reader["ID"],
                    ten = reader["TenKhoa"]
                });
            }

            return Json(list);
        }
        [HttpGet("api/phong")]
        public async Task<IActionResult> GetPhong(long idChiNhanh, long idKhoa)
        {
            var list = new List<object>();

            using var conn = _dbService.Database.GetDbConnection();
            await conn.OpenAsync();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "dbo.S00_LCDSoThuTu";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@IDChiNhanh", idChiNhanh));
            cmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@IDKhoa", idKhoa));
            cmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@IDPhongBuong", DBNull.Value));

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new
                {
                    id = reader["ID"],
                    ten = reader["TenPhong"]
                });
            }

            return Json(list);
        }

    }
}