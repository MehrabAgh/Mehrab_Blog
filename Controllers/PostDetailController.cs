using BlogUniversity.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogUniversity.Controllers
{
    public class PostDetailController : Controller
    {
        public IActionResult Index(int id)
        {         
            return View("PostDetail" , id );
        }
    }
}
