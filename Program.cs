using Microsoft.EntityFrameworkCore;
using SEYRÝ_ALA.Data;
using SEYRÝ_ALA.Data.Interfaces;
using SEYRÝ_ALA.Data.Repositories;
using SEYRÝ_ALA.Services;

var builder = WebApplication.CreateBuilder(args);

#region 1. DATABASE CONFIGURATION
// Veritabaný baðlantý dizesinin yapýlandýrýlmasý
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
#endregion

#region 2. DEPENDENCY INJECTION (DI) SERVICES

// --- Repositories ---
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// --- Business Logic Services ---
builder.Services.AddScoped<IRouteService, RouteService>();
builder.Services.AddScoped<UserPreferenceService>(); // Akýllý Tercih Motoru

// --- External API Services (Typed Clients) ---
builder.Services.AddHttpClient<IWeatherService, WeatherService>();
builder.Services.AddHttpClient<IDistanceService, DistanceService>();

#endregion

#region 3. AUTHENTICATION & SESSION
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", config =>
    {
        config.Cookie.Name = "UserLoginCookie";
        config.LoginPath = "/Account/Login";
        config.AccessDeniedPath = "/Account/AccessDenied";
        config.ExpireTimeSpan = TimeSpan.FromDays(7);
    });
#endregion

#region 4. LOCALIZATION & MVC CONFIG
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddControllersWithViews()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();
#endregion

var app = builder.Build();

#region 5. MIDDLEWARE PIPELINE (HTTP REQUEST)

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Güvenlik katmanlarý
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

// Dil desteði (Routing'den sonra, Endpoint'lerden önce olmalý)
var supportedCultures = new[] { "tr", "en" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("tr")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

#endregion

#region 6. ENDPOINT MAPPING
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion

app.Run();