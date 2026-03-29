using Microsoft.AspNetCore.Mvc;
using SEYRİ_ALA.Services;
using SEYRİ_ALA.Data.Interfaces;
using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;
        private readonly IWeatherService _weatherService;
        private readonly IDistanceService _distanceService;

        public CityController(ICityRepository cityRepository,
                              IWeatherService weatherService,
                              IDistanceService distanceService)
        {
            _cityRepository = cityRepository;
            _weatherService = weatherService;
            _distanceService = distanceService;
        }

        [HttpGet("/City/GetDistance")]
        public async Task<IActionResult> GetDistance(int cityId, double userLat, double userLon)
        {
            try
            {
                var city = await _cityRepository.GetByIdAsync(cityId);
                if (city == null) return NotFound();

                double cityLat = city.Latitude;
                double cityLon = city.Longitude;

                
                var distance = await _distanceService.GetRoadDistanceAsync(userLat, userLon, cityLat, cityLon);

                if (distance == 0)
                {
                    return Ok(new { distance = "Hesaplanamadı", cityName = city.Name });
                }

                return Ok(new
                {
                    distance = Math.Round(distance, 1),
                    cityName = city.Name
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mesafe Hatası: " + ex.Message);
                return StatusCode(500, "Mesafe hesaplanırken bir iç hata oluştu.");
            }
        }

        [HttpGet("/City/GetWeather")]
        public async Task<IActionResult> GetCityWeather(int cityId)
        {
            var city = await _cityRepository.GetByIdAsync(cityId);
            if (city == null) return NotFound();

            var (temp, condition) = await _weatherService.GetWeatherAsync(city.Name);

            if (temp != null)
            {
                city.Temperature = temp;
                city.WeatherCondition = condition;
                await _cityRepository.SaveChangesAsync();
            }

            return Ok(new
            {
                temperature = temp,
                weatherDescription = condition,
                cityName = city.Name
            });
        }
    }
}