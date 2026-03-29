namespace SEYRİ_ALA.Models
{

        public class Place
        {
            public int Id { get; set; }
            public string Name { get; set; } = null!;
            public string? Description { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public int CityId { get; set; } // Hangi şehre ait?
            public virtual City City { get; set; } = null!;
        }
    }

