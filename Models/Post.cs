using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SawitApi.Models 
{
    public class Post{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        [Required]
        public required string PostTitle {get ; set ;} 

        public  string ?PostContent {get ; set ;}

        public  string ?PostIMediaPath {get ; set ;}

        public DateTime CreatedAT {get; set ;} = DateTime.UtcNow;

        public virtual User User { get; set; } = null!;

    
    }
}