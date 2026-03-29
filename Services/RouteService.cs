using Microsoft.EntityFrameworkCore;
using SEYRİ_ALA.Data;
using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Services
{
    public class RouteService : IRouteService
    {
        private readonly ApplicationDbContext _context;
        private readonly IDistanceService _distanceService;

        public RouteService(ApplicationDbContext context, IDistanceService distanceService)
        {
            _context = context;
            _distanceService = distanceService;
        }

        public async Task<double> CalculateTotalDistanceAsync(List<int> cityIds)
        {
            if (cityIds == null || !cityIds.Any()) return 0;

            // 1. Siber İyileştirme: Veriyi hızlıca çek
            var cities = await _context.Cities
                .AsNoTracking() // Takibe alma, sadece oku (Performans artışı)
                .Where(c => cityIds.Contains(c.Id))
                .ToListAsync();

            // 2. Siber İyileştirme: Güvenli sıralama (Sadece var olan şehirleri al)
            var orderedCities = cityIds
                .Select(id => cities.FirstOrDefault(c => c.Id == id))
                .Where(c => c != null) // Bulunamayan şehirleri listeden çıkar (Çökmeyi engeller)
                .ToList();

            double totalDistance = 0;

            for (int i = 0; i < orderedCities.Count - 1; i++)
            {
                // Derece bazlı koordinatları mesafe servisine gönder
                totalDistance += await _distanceService.GetRoadDistanceAsync(
                    orderedCities[i]!.Latitude, orderedCities[i]!.Longitude,
                    orderedCities[i + 1]!.Latitude, orderedCities[i + 1]!.Longitude);
            }

            return totalDistance;
        }

        public async Task<int> CreateRouteAsync(string routeName, List<int> cityIds)
        {
            double totalDistance = await CalculateTotalDistanceAsync(cityIds);

            var newRoute = new TravelRoute
            {
                Title = routeName,
                TotalDistance = totalDistance,
                Description = $"{routeName} rotası - Toplam mesafe: {totalDistance:F2} KM" // Daha zengin içerik
            };

            _context.Routes.Add(newRoute);
            await _context.SaveChangesAsync();

            return newRoute.Id;
        }
    }
}