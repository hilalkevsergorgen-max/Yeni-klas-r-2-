using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);
        Task SaveChangesAsync();
    }
}
