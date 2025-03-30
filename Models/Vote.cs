using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SawitApi.Models
{
    public class Vote {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VoteId { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Campagne")] 
        public int CampagneId { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        public DateTime VotedAT { get; set; } = DateTime.UtcNow;

        /* realationships */

        public virtual User User { get; set; } = null!;
        public virtual Campagne Campagne { get; set; } = null!;

        public virtual Candidate Candidate {get; set; } = null!;

    }
}