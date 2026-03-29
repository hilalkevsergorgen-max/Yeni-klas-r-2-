namespace SEYRİ_ALA.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        // Hangi şehir favori?
        public int CityId { get; set; }
        public City City { get; set; } = null!;

        // Kim favoriye ekledi?
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}