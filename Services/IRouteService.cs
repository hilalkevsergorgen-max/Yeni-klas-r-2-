public interface IRouteService
{
    Task<double> CalculateTotalDistanceAsync(List<int> cityIds);
    Task<int> CreateRouteAsync(string routeName, List<int> cityIds); // Bunu da ekle
}