using Microsoft.AspNetCore.Mvc;
using Projects.Models;
using Projects.Data;

namespace Projects.Controllers
{
    public class WayController : Controller
    {
        private readonly Projects.Data.ProjectsContext _context;
        public struct Result 
        {
            public string response {  get; set; }
            public Project project { get; set; }

        }
        public WayController(Projects.Data.ProjectsContext context) { _context = context; }

        [HttpGet("FindByProductId/{project_id}")]
        public ActionResult<Result> findbyproduct_id(int project_id)
        {
            // 尝试从数据库中查找具有指定 product_id 的项目
            Project foundProject = _context.Project.FirstOrDefault(p => p.project_id == project_id);
            Result result = new Result();
            if (foundProject != null)
            {
                result.response = "找到项目";
                result.project = foundProject;
            }
            else
            {
                result.response = "未找到项目";
                result.project = null;
            }
            return result;
        }
    }
}
