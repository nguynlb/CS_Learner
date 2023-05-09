using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef.Entity {
    [Table("UserInfo")]
    public class User 
    {
        [Key]
        public int Id {get; set;}

        [Required]
        [StringLength(20)]
        public string? Username {get; set;}

        [Required]
        [StringLength(20)]
        public string? Email {get; set;}
    }
}