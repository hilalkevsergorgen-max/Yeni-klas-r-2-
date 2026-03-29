using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using SEYRİ_ALA.Data;
using SEYRİ_ALA.Services;
using SEYRİ_ALA.Models; // Favorite modeli için gerekli
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims; // User ID çekmek için
using System.Threading.Tasks;

namespace SEYRİ_ALA.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteService _routeService;
        private readonly ApplicationDbContext _context;

        public RouteController(IRouteService routeService, ApplicationDbContext context)
        {
            _routeService = routeService;
            _context = context;
        }

        // --- HAFTA 4 GÖREVİ: GELİŞMİŞ AJAX FAVORİ/BEĞENİ MOTORU ---
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ToggleLike(int cityId)
        {
            try
            {
                //  Giriş yapmış kullanıcının ID'sini çekiyoruz
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(userIdString)) return Unauthorized();
                var userId = int.Parse(userIdString);

                //  Bu şehir daha önce favorilenmiş mi? (Veritabanı kontrolü)
                var existingFavorite = await _context.Favorites
                    .FirstOrDefaultAsync(f => f.CityId == cityId && f.UserId == userId);

                bool isLikedNow;

                if (existingFavorite != null)
                {
                    // Varsa: Favorilerden kaldır (Beğeniyi geri çek)
                    _context.Favorites.Remove(existingFavorite);
                    isLikedNow = false;
                }
                else
                {
                    // Yoksa: Yeni favori kaydı oluştur
                    var newFavorite = new Favorite
                    {
                        CityId = cityId,
                        UserId = userId
                    };
                    _context.Favorites.Add(newFavorite);
                    isLikedNow = true;
                }

                await _context.SaveChangesAsync();

                
                return Ok(new { success = true, isLiked = isLikedNow });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // <summary>
        // Hafta 3 & 4: Veritabanından dinamik rota verilerini çeken siber motor.
        // </summary>
        [Authorize]
        [HttpGet("test-route")]
        public async Task<IActionResult> TestRoute()
        {
            try
            {
                // Mevcut kullanıcının favorilerini de listeye dahil ediyoruz ki haritada "beğenilmiş" gelsin
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userId = !string.IsNullOrEmpty(userIdString) ? int.Parse(userIdString) : 0;

                var cities = await _context.Cities
                    .Include(c => c.Favorites) // Favori ilişkisini dahil et
                    .AsNoTracking()
                    .OrderByDescending(c => c.HistoryScore)
                    .Take(5)
                    .ToListAsync();

                if (cities == null || !cities.Any())
                {
                    return NotFound(new { Mesaj = "Veritabanında görüntülenecek şehir bulunamadı kardo!" });
                }

                var routePoints = cities.Select(c => new
                {
                    Id = c.Id,
                    Ad = c.Name ?? "Bilinmeyen Şehir",
                    Lat = c.Latitude,
                    Lng = c.Longitude,
                    // Kullanıcı bu şehri favorilemiş mi?
                    IsLiked = c.Favorites.Any(f => f.UserId == userId),
                    Resim = !string.IsNullOrEmpty(c.Name)
                            ? $"https://loremflickr.com/400/250/{c.Name.ToLower().Replace(" ", "")},city"
                            : "https://loremflickr.com/400/250/city",
                    Puan = (double)(c.HistoryScore + c.NatureScore + c.FoodScore) / 3.0,
                    Bilgi = !string.IsNullOrEmpty(c.Description) && c.Description.Length > 100
                            ? c.Description.Substring(0, 100) + "..."
                            : (c.Description ?? "Bu şehir hakkında henüz bir detay girilmemiş.")
                }).ToList();

                var ids = cities.Select(c => c.Id).ToList();
                var distance = await _routeService.CalculateTotalDistanceAsync(ids);

                return Ok(new
                {
                    Noktalar = routePoints,
                    HesaplananKM = distance,
                    Mesaj = "Veriler siber sistem üzerinden başarıyla senkronize edildi!"
                });
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, new { Mesaj = "Siber bir hata oluştu kardo.", Detay = ex.Message });
            }
        }
    }
}