using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Data.Interfaces
{
    public interface ICityRepository        // Şehirlerle ilgili hangi işlemleri yapacağımıza karar verdiğimiz yer 
    {
        Task<IEnumerable<City>> GetAllAsync();
        Task<City?> GetByIdAsync(int id);
        Task<bool> AddFavoriteAsync(int cityId, int userId);
        Task<bool> RemoveFavoriteAsync(int cityId, int userId);
        Task<bool> IsFavoriteAsync(int cityId, int userId);

        Task AddCommentAsync(Comment comment);
        Task<Comment?> GetCommentByIdAsync(int id);
        Task DeleteCommentAsync(Comment comment);
        Task ToggleFavoriteAsync(int cityId, int userId);
        Task SaveChangesAsync(); // Değişiklikleri kaydetmek için
        Task<IEnumerable<City>> GetFavoritesByUserIdAsync(int userId);
    }
}
