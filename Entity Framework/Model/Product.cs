using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef.Model {
    [Table("Product")]
    public class Product {

        [Key]
        public int Id {get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Price {get; set;}

        public int CatagoryId {get; set; }

        public Catagory Catagory { get; set; }

        public override string ToString() => $"{Id,4} - {Name, 10} - {Price, 4}";
    }
}