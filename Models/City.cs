using System.ComponentModel.DataAnnotations;

namespace SEYRİ_ALA.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        // Harita koordinatları (Leaflet için)
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // AI Puanlama Kriterleri (0-10)
        public int HistoryScore { get; set; }
        public int NatureScore { get; set; }
        public int FoodScore { get; set; }

        //  BEĞENİ SİSTEMİ İÇİN EKLENEN SAYAÇ
        public int LikeCount { get; set; } = 0;

        // Şehre yapılan yorumların listesi
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        // Favori İlişkisi
        public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

        public string? WeatherCondition { get; set; } // "Güneşli", "Yağmurlu" vb.
        public double? Temperature { get; set; }      // Derece bilgisi
    }
}