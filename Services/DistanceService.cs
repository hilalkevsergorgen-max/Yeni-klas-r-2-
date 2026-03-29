using System.Globalization;
using System.Text.Json;
using System.Globalization;

namespace SEYRİ_ALA.Services
{
    public class DistanceService : IDistanceService 
    {
        private readonly HttpClient _httpClient;

        public DistanceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<double> GetRoadDistanceAsync(double lat1, double lon1, double lat2, double lon2)
        {
            // OSRM Karayolu Servisi
         
            var url = string.Format(CultureInfo.InvariantCulture,
                "https://router.project-osrm.org/route/v1/driving/{0},{1};{2},{3}?overview=false",
                lon1, lat1, lon2, lat2);
            try
            {
                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    using var doc = JsonDocument.Parse(content);

                    double meters = doc.RootElement
                        .GetProperty("routes")[0]
                        .GetProperty("distance")
                        .GetDouble();

                    return meters / 1000; // KM'ye çeviriyoruz
                }
            }
            catch (Exception)
            {
                return 0; // Hata durumunda güvenli çıkış
            }
            return 0;
        }
    }
}