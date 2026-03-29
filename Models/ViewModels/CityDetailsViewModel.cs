namespace SEYRİ_ALA.Models.ViewModels
{
    public class CityDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int HistoryScore { get; set; }
        public int NatureScore { get; set; }
        public int FoodScore { get; set; }
        public bool IsFavorite { get; set; } // Kullanıcının favorisi mi? (Yeni özellik)

        // --- 2. HAFTA: HAVA DURUMU İÇİN EKLENEN KISIM ---
        public string? Temperature { get; set; } // Şehrin anlık sıcaklığı
        public string? WeatherDescription { get; set; } // "Güneşli", "Bulutlu" gibi kısa özet
        // -----------------------------------------------

        // Sadece gerekli yorum verileri
        public List<CommentViewModel> Comments { get; set; } = new();
    }

    public class CommentViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool IsBelongsToUser { get; set; } // Silme butonu görünsün mü?
    }
}