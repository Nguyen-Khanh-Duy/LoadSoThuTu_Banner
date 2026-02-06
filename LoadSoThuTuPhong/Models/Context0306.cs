

using Microsoft.EntityFrameworkCore;

namespace LoadSoThuTuPhong.Models
{
    public class Context0306 : DbContext
    {

        public Context0306(DbContextOptions<Context0306> options) : base(options) { }
        public DbSet<ChiNhanhModel> ChiNhanhModels{ get; set; }
        public DbSet<BannerModel> BannerModels { get; set; }
        public DbSet<BenhNhanThuTuModel> BenhNhanThuTuModels{ get; set; }
        public DbSet<LoadLCDSoThuTuPhongModel> LCDSoThuTu { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LoadLCDSoThuTuPhongModel>().HasNoKey();
            modelBuilder.Entity<BenhNhanThuTuModel>().HasNoKey();
           
        }

        public bool TestConnection()
        {
            try
            {
                return this.Database.CanConnect();
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
