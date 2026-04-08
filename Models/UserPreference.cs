using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEYRİ_ALA.Models
{
    public class UserPreference
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Range(0.0, 1.0)]
        public double NatureScore { get; set; } = 0.5; // Nötr başlangıç

        [Range(0.0, 1.0)]
        public double HistoryScore { get; set; } = 0.5; // Nötr başlangıç

        [Range(0.0, 1.0)]
        public double BudgetScore { get; set; } = 0.5; // Nötr başlangıç

        public string? LastInteractedCity { get; set; }

        // AI için biriken metin verisi, ilerde text-heavy olabilir.
        public string? AISelectionContext { get; set; }

        // virtual keyword'ü EF'in nesneyi daha rahat yönetmesini sağlar.
        public virtual User? User { get; set; }
    }
}