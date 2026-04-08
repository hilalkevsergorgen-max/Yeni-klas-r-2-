using SEYRİ_ALA.Models;

namespace SEYRİ_ALA.Models
{
    public class TravelRoute
    {
        public int Id { get; set; }

        public int CityId { get; set; }
        public City City { get; set; } = null!;

        public string Title { get; set; } = null!;
        public string? AiSuggestion { get; set; } // AI'nın rota hakkındaki tavsiyesi buraya yazılacak.
        public string Description { get; set; } = null!;
        public string? MapGeoJson { get; set; }
        public double Latitude { get; set; }  // Enlem
        public double Longitude { get; set; } // Boylam
        public double TotalDistance { get; set; } // KM cinsinden toplam mesafe
    }
}
