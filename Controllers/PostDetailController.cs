using Microsoft.AspNetCore.Mvc;

namespace BlogUniversity.Controllers
{
    public class PostDetailController : Controller
    {
        public IActionResult Index(int id)
        {
            Console.WriteLine(id);
            return View("PostDetail");
        }
    }
}
