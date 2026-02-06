
using LoadSoThuTuPhong.Models;
using LoadSoThuTuPhong.Models.Entities;
using LoadSoThuTuPhong.Service;
using LoadSoThuTuPhong.Service.IS;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });
builder.Services.AddScoped<LoadSoThuTuPhongInterface, LoadLCDSoThuTuPhongService>();
builder.Services.AddScoped<IFtpService, FtpService>();
// Đăng ký DbContext với connection string
builder.Services.AddDbContext<Context0306>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

builder.Services.AddDbContext<HisContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

// Cấu hình Session (SỬA TỪ services -> builder.Services)
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });

builder.Services.AddHttpContextAccessor();

// Cấu hình CultureInfo cho ứng dụng
var cultureInfo = new CultureInfo("en-US");
cultureInfo.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
cultureInfo.DateTimeFormat.DateSeparator = "-";
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();  // Sử dụng Session middleware
app.UseRouting();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=LoadSoThuTuPhong}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
