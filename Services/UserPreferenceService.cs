using SEYRİ_ALA.Models;
using SEYRİ_ALA.Data;
using Microsoft.EntityFrameworkCore;

namespace SEYRİ_ALA.Services
{
    public class UserPreferenceService
    {
        private readonly ApplicationDbContext _context;

        public UserPreferenceService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Kullanıcı etkileşimine göre profil puanlarını günceller.
        /// </summary>
        public async Task UpdatePreferenceAsync(int userId, string category, string cityName)
        {
            // 1. Kullanıcının tercih kaydını getir
            var preference = await _context.UserPreferences
                .FirstOrDefaultAsync(p => p.UserId == userId);

            // 2. Kayıt yoksa "Nötr (0.5)" değerlerle ilk kez oluştur
            if (preference == null)
            {
                preference = new UserPreference
                {
                    UserId = userId,
                    NatureScore = 0.5,
                    HistoryScore = 0.5,
                    BudgetScore = 0.5,
                    AISelectionContext = "" // Boş string başlatmak null hatalarını önler
                };
                await _context.UserPreferences.AddAsync(preference);
            }

            // 3. Kategoriye göre skor güncelleme (Max 1.0 sınırı ile)
            // Puan artış miktarını 0.05 yaparak öğrenme sürecini daha dengeli hale getirdik.
            double increment = 0.05;

            switch (category.ToLower())
            {
                case "doğa":
                case "nature":
                    preference.NatureScore = Math.Min(1.0, preference.NatureScore + increment);
                    break;
                case "tarih":
                case "history":
                    preference.HistoryScore = Math.Min(1.0, preference.HistoryScore + increment);
                    break;
                case "ekonomi":
                case "ekonomik":
                case "budget":
                    preference.BudgetScore = Math.Min(1.0, preference.BudgetScore + increment);
                    break;
            }

            // 4. Son etkileşim verilerini güncelle
            preference.LastInteractedCity = cityName;

            // 5. AI Context Yönetimi (Rolling Log)
            // Her etkileşimi tarihle beraber en başa ekleriz.
            string newEntry = $"[{DateTime.Now:dd/MM HH:mm}] {cityName} ({category}) | ";
            preference.AISelectionContext = newEntry + preference.AISelectionContext;

            // Veritabanının şişmemesi için metni 500 karakterle sınırlıyoruz.
            if (preference.AISelectionContext.Length > 500)
            {
                preference.AISelectionContext = preference.AISelectionContext.Substring(0, 500);
            }

            // 6. Değişiklikleri kaydet
            await _context.SaveChangesAsync();
        }
    }
}