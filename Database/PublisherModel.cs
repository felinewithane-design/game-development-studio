using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace game_development_studio.Database
{
    [Table("Publishers")]
    public class PublisherModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? ContactTerms { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? FundingAmount { get; set; }
    }
}