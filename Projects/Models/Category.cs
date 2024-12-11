using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projects.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int category_id { get; set; }

        public string name { get; set; }
        public bool status { get; set; }
        public string description { get; set; }

        [ForeignKey("parentCategory")]
        public int? parentcategory_id { get; set; }
        public virtual Category parentCategory { get; set; }

        public int admin_id { get; set; }

    }
}
