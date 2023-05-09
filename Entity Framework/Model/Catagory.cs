using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef.Model {
   [Table("Catagory")]
    public class Catagory
    {
        [Key]
        public int Id {get; set;}

        [Required]
        [StringLength(20)]
        public string Name {get; set;}

        [Required]
        [StringLength(20)]
        public string Description {get; set;}

        public override string ToString() => $"{Id, 4} - {Name, 10} - {Description , 20}";
    }
 }