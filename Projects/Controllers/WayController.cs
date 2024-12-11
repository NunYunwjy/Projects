using Microsoft.AspNetCore.Mvc;

namespace Projects.Controllers
{
    [Route("test")] // 基路由，将处理 /test 的请求
    public class WayController : Controller
    {
        [HttpGet("a")] // 完整的路由将变成 /test/a
        public IActionResult Print()
        {
            var data = new { message = "aaa" }; // 创建一个匿名对象作为 JSON 数据
            return Json(data); // 返回 JSON 结果
        }
    }
}
