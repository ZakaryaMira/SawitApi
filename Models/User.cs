using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawitApi.Models
{
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public required string UserName {get ; set ; }

        public required string FirstName {get ; set ;}

        public required string LastName {get ; set ;}

        public required string Email {get ; set ;}

        public required string PasswordHashed {get ; set ;}

        public required DateTime CreatedAt {get ; set ;} = DateTime.UtcNow;

        public bool IsActive {get ; set ;}

        /* relatioShip */

        /* public Campagne ?Campagne {get ; set ;}  */
        public List<Campagne> Campagnes {get ; set ;} = [];
        public List<Candicate>  Candidates {get ; set ;} = []; //Candicates
        public List<Experience> Experience {get ; set ;} = [];
        public List<Post> Post {get ; set ;} = [];
        public List<Vote> Vote {get ; set ;} = []; 
    }
}