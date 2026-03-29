
using Microsoft.EntityFrameworkCore;
using SEYRÝ_ALA.Data; 
using SEYRÝ_ALA.Data.Interfaces;
using SEYRÝ_ALA.Data.Repositories;
using SEYRÝ_ALA.Services;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddScoped<ICityRepository, CityRepository>(); // ýcityrepostories istendiðinde cityrepostories verilir
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddHttpClient<IDistanceService, DistanceService>();

//veritabaný baðlantý dizesini çekme
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddControllersWithViews()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();
// oturum yönetimi
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication("CookieAuth") //kimlik doðrulama kartý gibi düþünebiliriz 
    .AddCookie("CookieAuth", config =>
    {
        config.Cookie.Name = "UserLoginCookie";
        config.LoginPath = "/Account/Login"; // Yetkisiz giriþte yönlendirilecek sayfa
    });

var supportedCultures = new[] { "tr", "en" };
var localizationOptions = new RequestLocalizationOptions() // çoklu dil desteði ayarlarý
    .SetDefaultCulture("tr")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);


builder.Services.AddHttpClient<IWeatherService, WeatherService>(); // hava durumu verilerini çekmek için httpclient 
builder.Services.AddScoped<IDistanceService, DistanceService>();
builder.Services.AddScoped<IRouteService, RouteService>();
var app = builder.Build();


if (!app.Environment.IsDevelopment()) //
{
    app.UseExceptionHandler("/Home/Error"); 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Kimlik doðrulamayý aktif eder

app.UseSession();

app.UseAuthorization();
app.UseRequestLocalization(localizationOptions); 

//varsayýlan sayfada açýlmasý için 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
