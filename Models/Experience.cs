using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawitApi.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExperienceId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public required string ExpeienceDescription { get; set; }
        public virtual User User { get; set; } = null!;
    }
}