using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace game_development_studio.Database
{
    [Table("DevelopmentTeams")]
    public class DevelopmentTeamModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string TeamName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Specialization { get; set; }

        [Range(1, 10000)]
        public int NumberOfMembers { get; set; }

        [MaxLength(200)]
        public string? LeadDeveloper { get; set; }
    }
}