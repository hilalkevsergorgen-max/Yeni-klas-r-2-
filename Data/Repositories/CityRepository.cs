using Microsoft.EntityFrameworkCore;
using SEYRİ_ALA.Data.Interfaces;
using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Data.Repositories
{
  
    public class CityRepository : ICityRepository // yapılacak işlemlerin nasıl yapılacağını anlatan yer 
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetAllAsync() => await _context.Cities.ToListAsync();  //tüm şehirleri getir

        public async Task<City?> GetByIdAsync(int id) => await _context.Cities //şehrin id si sayesinde yorum+ favori bilgisini de getir
                .Include(c => c.Comments).ThenInclude(u => u.User)
                .Include(c => c.Favorites)
                .FirstOrDefaultAsync(m => m.Id == id);

        public async Task AddCommentAsync(Comment comment) => await _context.Comments.AddAsync(comment); // yorum ekle

        public async Task<Comment?> GetCommentByIdAsync(int id) => //yorumu id siyle getir
            await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);

        public async Task DeleteCommentAsync(Comment comment) => _context.Comments.Remove(comment);


        public async Task<bool> IsFavoriteAsync(int cityId, int userId) => //şehir kullanıcının favori listesinde mi kontrolü
            await _context.Favorites.AnyAsync(f => f.CityId == cityId && f.UserId == userId);

        public async Task<IEnumerable<City>> GetFavoritesByUserIdAsync(int userId) //favori şehirleri getir
        {
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.City)
                .Select(f => f.City)
                .ToListAsync();
        }

        public async Task ToggleFavoriteAsync(int cityId, int userId)  //şehir favori ise kaldır değilse ekle
        {
            var fav = await _context.Favorites.FirstOrDefaultAsync(f => f.CityId == cityId && f.UserId == userId);
            if (fav != null) _context.Favorites.Remove(fav);
            else await _context.Favorites.AddAsync(new Favorite { CityId = cityId, UserId = userId });
        }

        public async Task<bool> AddFavoriteAsync(int cityId, int userId)//favoriye ekle 
        {
            var exists = await _context.Favorites.AnyAsync(f => f.CityId == cityId && f.UserId == userId);
            if (!exists)
            {
                await _context.Favorites.AddAsync(new Favorite { CityId = cityId, UserId = userId });

                //  Beğeni sayısını senkronize et
                var city = await _context.Cities.FindAsync(cityId);
                if (city != null) city.LikeCount++;

                return true;
            }
            return false;
        }

        public async Task<bool> RemoveFavoriteAsync(int cityId, int userId) //favoriden kaldır
        {
            var fav = await _context.Favorites.FirstOrDefaultAsync(f => f.CityId == cityId && f.UserId == userId);
            if (fav != null)
            {
                _context.Favorites.Remove(fav);
                var city = await _context.Cities.FindAsync(cityId);
                if (city != null && city.LikeCount > 0) city.LikeCount--;
                return true;
            }
            return false;
        }

   

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();  // veritabanına değişikliği kaydet

       
    }
}