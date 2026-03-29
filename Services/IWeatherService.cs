namespace SEYRİ_ALA.Services
{
    public interface IWeatherService
    {
        // Geriye hem sıcaklığı hem de durumu (bulutlu, güneşli vb.) döndüren metot
        Task<(double? Temp, string? Condition)> GetWeatherAsync(string cityName);
    }
}