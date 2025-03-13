using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawitApi.Models
{
    public class User {
        [Key]
        public int Userid { get; set; }
        public string UserName {get ; set ; }

        public string FirstName {get ; set ;}

        public string LastName {get ; set ;}

        public string PasswordHashed {get ; set ;}

        public DateOnly CreatedAt {get ; set ;}

        public bool IsActive {get ; set ;}
    }
}