using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawitApi.Models
{
    public class Campagne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CampagneId { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        [Required]
        public required string  CampagneName { get; set; }
        [Required]
        public required string CampagneDescription {get; set;}
        [Required]

        public required DateTime Startdate { get; set; } = DateTime.UtcNow;
        [Required]

        public required DateTime Enddate { get; set; }

   
        /* relations */
        public virtual User User { get; set; } = null!;
        
        public virtual Candidate Candicate { get; set; } = null!;

    }
}