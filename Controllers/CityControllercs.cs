using Microsoft.AspNetCore.Mvc;
using SEYRİ_ALA.Services;
using SEYRİ_ALA.Data.Interfaces;
using SEYRİ_ALA.Models;
using System.Security.Claims;

namespace SEYRİ_ALA.Controllers
{
    /// <summary>
    /// SEYRİ ALA - Şehir Operasyonları ve Kullanıcı Analiz Merkezi
    /// Bu controller, kullanıcı etkileşimlerini sessizce analiz ederek kişiselleştirilmiş bir deneyim sunar.
    /// </summary>
    public class CityController : Controller
    {
        #region 1. Dependencies (Bağımlılıklar)

        private readonly ICityRepository _cityRepository;
        private readonly IWeatherService _weatherService;
        private readonly IDistanceService _distanceService;
        private readonly UserPreferenceService _userPreferenceService;

        public CityController(
            ICityRepository cityRepository,
            IWeatherService weatherService,
            IDistanceService distanceService,
            UserPreferenceService userPreferenceService)
        {
            _cityRepository = cityRepository;
            _weatherService = weatherService;
            _distanceService = distanceService;
            _userPreferenceService = userPreferenceService;
        }
        #endregion

        #region 2. Public API Endpoints

        /// <summary>
        /// Kullanıcı ile şehir arasındaki mesafeyi hesaplar ve etkileşimi analiz motoruna gönderir.
        /// </summary>
        [HttpGet("/City/GetDistance")]
        public async Task<IActionResult> GetDistance(int cityId, double userLat, double userLon)
        {
            try
            {
                var city = await _cityRepository.GetByIdAsync(cityId);
                if (city == null) return NotFound(new { error = "Hedef şehir bulunamadı." });

                // Mekanik: Mesafe sorgusu bir 'ilgi' göstergesidir.
                // Fire-and-forget yerine await kullanarak veri bütünlüğünü garanti ediyoruz.
                await TrackUserInteraction(city);

                var distance = await _distanceService.GetRoadDistanceAsync(userLat, userLon, city.Latitude, city.Longitude);

                return Ok(new
                {
                    distance = distance > 0 ? Math.Round(distance, 1).ToString() : "Hesaplanamadı",
                    cityName = city.Name,
                    timestamp = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                // Kritik: Kullanıcıya teknik detay vermeden hata yönetimi
                return StatusCode(500, "Mesafe hesaplama servisi şu an kullanılamıyor.");
            }
        }

        /// <summary>
        /// Şehrin hava durumunu çeker, cache yerine canlı veriyi günceller ve tercihlerle bağdaştırır.
        /// </summary>
        [HttpGet("/City/GetWeather")]
        public async Task<IActionResult> GetCityWeather(int cityId)
        {
            var city = await _cityRepository.GetByIdAsync(cityId);
            if (city == null) return NotFound();

            try
            {
                // Hava durumu verisini çek (Mekanik: Harici API servisi)
                var (temp, condition) = await _weatherService.GetWeatherAsync(city.Name);

                if (temp != null)
                {
                    city.Temperature = temp;
                    city.WeatherCondition = condition;

                    // Paralel Operasyon: Hem DB güncellenir hem de kullanıcı tercihi işlenir.
                    // Performans için iki işlemi aynı anda bekliyoruz.
                    await Task.WhenAll(
                        _cityRepository.SaveChangesAsync(),
                        TrackUserInteraction(city)
                    );
                }

                return Ok(new { temperature = temp, weatherDescription = condition, cityName = city.Name });
            }
            catch (Exception ex)
            {
                // Fail-safe: Hava durumu çökerse uygulama durmaz, boş veri döner.
                return Ok(new { temperature = "--", weatherDescription = "Servis dışı", cityName = city.Name });
            }
        }

        #endregion

        #region 3. Core Engine - Private Methods

        /// <summary>
        /// Kullanıcının dijital ayak izini takip eden gizli mekanizma.
        /// </summary>
        private async Task TrackUserInteraction(City city)
        {
            try
            {
                // Claim üzerinden güvenli UserId çekimi
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (int.TryParse(userIdClaim, out int userId))
                {
                    // Mekanik Koruma: Şehrin NatureScore ve HistoryScore değerlerini kıyaslayarak
                    // kullanıcının o anki eğilimini (Nature vs History) belirliyoruz.
                    string dominantCategory = city.NatureScore >= city.HistoryScore ? "doğa" : "tarih";

                    // Akıllı Servise Gönder (Hafıza Kartı Güncellemesi)
                    await _userPreferenceService.UpdatePreferenceAsync(userId, dominantCategory, city.Name);
                }
            }
            catch (Exception ex)
            {
                // Bu metot sessiz çalışmalı (Silent Auditor). 
                // Bir hata olursa ana işlemi (Hava durumu/Mesafe) patlatmamalı.
                System.Diagnostics.Debug.WriteLine($"[Analysis Engine Error]: {ex.Message}");
            }
        }

        #endregion
    }
}