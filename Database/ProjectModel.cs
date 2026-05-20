using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace game_development_studio.Database
{
    [Table("Projects")]
    public class ProjectModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Genre { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Budget { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        public DateTime? StartDate { get; set; }

        public DateTime? Deadline { get; set; }

        // Foreign keys
        public int? ProducerId { get; set; }
        public int? PublisherId { get; set; }
        public int? DevelopmentTeamId { get; set; }

        // Navigation properties
        [ForeignKey("ProducerId")]
        public ProducerModel? Producer { get; set; }

        [ForeignKey("PublisherId")]
        public PublisherModel? Publisher { get; set; }

        [ForeignKey("DevelopmentTeamId")]
        public DevelopmentTeamModel? DevelopmentTeam { get; set; }

        [MaxLength(1000)]
        public string? Notes { get; set; }
    }
}