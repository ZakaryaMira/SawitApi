using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Routing.Matching;

namespace SawitApi.Models
{
    public class Candidate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandidateId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Campagne")]
        public int CampagneId { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public CandidateStatus Status { get; set; } = CandidateStatus.pending;

        public enum CandidateStatus {
            pending,
            accepted,
            rejected
        }
        /* relationship  */
        public virtual User User { get; set; } = null!;
        public virtual Campagne Campagne { get; set; } = null!;
    }
}