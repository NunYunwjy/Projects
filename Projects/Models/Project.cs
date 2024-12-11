using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projects.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int project_id { get; set; }
        public string type { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public string requirements { get; set; }
        public DateTime begintime { get; set; }
        public DateTime endtime { get; set; }
        public DateTime createtime { get; set; }
        public int status { get; set; }//-1表示待审核，0表示已审核未通过，1表示已审核通过
        public string? level { get; set; }//竞赛、大创
        public string? major { get; set; }//科研项目、毕业论文、大创、找帮手
        public int? teacher_id { get; set; }
        public int? student_id { get; set; }
        public int? admin_id { get; set; }
        public string? comment { get; set; }//审核意见
        public DateTime? aduittime { get; set; }//审核时间

        // 外键关系
        [ForeignKey("category")]
        public int category_id { get; set; }//直接填写二级目录的category_id
        public virtual Category category { get; set; }
    }
}
