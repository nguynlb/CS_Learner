using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace migration.Model {
    public class Tag {
        [Key]
        [StringLength(20)]
        public string TagId {get; set;}

        [Column(TypeName = "ntext")]
        public string Context {get; set;}
    }
}