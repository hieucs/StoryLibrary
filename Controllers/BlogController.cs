using Microsoft.AspNetCore.Mvc;

namespace StoryLibrary.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult TinTuc()
        {
            return View();
        }
    }
}
