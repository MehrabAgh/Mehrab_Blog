using BlogUniversity.Data;
using BlogUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogUniversity.Controllers
{
    public class PortfolioController : Controller
    {

        public BlogDbContext _context;

        public PortfolioController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Post([FromBody] Portfolio portfolio)
        {
            //add staff to the context            
            _context.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("#");
        }   


        public IActionResult Index()
        {
            LayoutData.ChangeDataTitle("", "", "", "active");

            List<PortfolioModel> myModel =
            [
                new(1, "app", "app-shatel", "/Portfolio/app-shatel.jpg", "",""),
                new(2, "app", "app-shop", "/Portfolio/app-shop.jpg", "",""),
                new(3, "app", "app-university", "/Portfolio/app-unive.jpg", "",""),
                new(4, "ai", "ar-model", "/Portfolio/ar.jpg", "", "/Portfolio/ar-model.mp4"),
                new(5, "game", "battle-of-ship", "/Portfolio/battle-of-ship-img.jpg", "", "/Portfolio/battle-of-ship-vid.mp4"),
                new(6, "game", "run-gun", "/Portfolio/run-gun-img.jpg", "", "/Portfolio/run-gun-vid.mp4"),
                new(7, "game", "the ultimate war", "/Portfolio/fbbbgb.jpg", "", "/Portfolio/asdvvb.mp4"),
                new(8, "game", "salad battle", "/Portfolio/saladbattle.jpg", "", "/Portfolio/saladbattle.mp4"),
                new(9, "game", "water-cup", "/Portfolio/water-cup-img.jpg", "", "/Portfolio/water-cup-vid.mp4"),
                new(10, "app", "app-mehr", "/Portfolio/app-mehr.webp", "", "")
            ];
            return View("Portfolio" , myModel);
        }
    }
}
