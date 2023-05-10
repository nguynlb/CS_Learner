using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace migration.Model {
    public class Article {
        [Key]
        public int ArticleId {get; set;}

        [Column(TypeName = "ntext" )]
        public string Title {get; set;}
    }
}