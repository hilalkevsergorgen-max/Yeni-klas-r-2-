namespace SEYRİ_ALA.Services
{
    public interface IDistanceService
    {
        Task<double> GetRoadDistanceAsync(double lat1, double lon1, double lat2, double lon2);
    }
}