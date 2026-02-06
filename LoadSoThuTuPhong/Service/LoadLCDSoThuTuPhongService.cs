
using LoadSoThuTuPhong.Service.IS;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using LoadSoThuTuPhong.Models;
namespace LoadSoThuTuPhong.Service
{
    public class LoadLCDSoThuTuPhongService : LoadSoThuTuPhongInterface
    {
        private readonly Context0306 _dbService;
        private readonly ILogger<LoadLCDSoThuTuPhongService> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoadLCDSoThuTuPhongService(Context0306 dbService,
            ILogger<LoadLCDSoThuTuPhongService> logger,
            IHttpContextAccessor httpContextAccessor)
        {
            _dbService = dbService;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<(bool Success, string Message, object Data)>
 FilterSoThuTuPhong(long IdPhongBuong, long IdChiNhanh)
        {
            try
            {
                int khoaMacDinh = 1;

                var data = await _dbService.LCDSoThuTu
                    .FromSqlRaw(
                        "EXEC S00_LCDSoThuTu @IDChiNhanh, @IDKhoa, @IDPhongBuong",
                        new SqlParameter("@IDChiNhanh", IdChiNhanh),
                        new SqlParameter("@IDKhoa", khoaMacDinh),
                        new SqlParameter("@IDPhongBuong", IdPhongBuong)
                    )
                    .AsNoTracking()
                    .ToListAsync();

                return (true, "OK", new
                {
                    Data = data,
                    ThoiGian = 5000,
                    SoDong = 10
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi gọi Stored LCD");
                return (false, ex.Message, null);
            }
        }


    }
}