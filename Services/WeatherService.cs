using System.Net.Http.Json;
using System.Text.Json;

namespace SEYRİ_ALA.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration; // apıkey i başka bir yerde saklamak için
        }

        public async Task<(double? Temp, string? Condition)> GetWeatherAsync(string cityName) 
        {
            // apı anahtar ve bağlantı bilgisini ayarlardan çekiyoruz kod içinde görünmesin  
            var apiKey = _configuration["WeatherApi:ApiKey"]; 
            var baseUrl = _configuration["WeatherApi:BaseUrl"]; 
          
            var url = $"{baseUrl}weather?q={cityName}&appid={apiKey}&units=metric&lang=tr"; //openweathermap in istediği formatta bağlantı adresi oluştur

            try
            {
                var response = await _httpClient.GetAsync(url); // internetteki veriyi al ve hazırlanan adrese getir
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<JsonElement>();

                    // gelen devasa veri yığını içinden ihtiyacımız olan bilgileri alıyoruz
                    double? temp = data.GetProperty("main").GetProperty("temp").GetDouble();
                    string? condition = data.GetProperty("weather")[0].GetProperty("description").GetString();

                    return (temp, condition);
                }
            }
            catch (Exception)
            {
                // API hatası alırsak null dönüyoruz ki sistem çökmesin
                return (null, null);
            }
            return (null, null);
        }
    }
}