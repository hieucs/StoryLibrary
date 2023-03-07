using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoryLibrary.DB;
using StoryLibrary.Pages;

namespace StoryLibrary.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var model = LoadData();

            return View("Index", model);
        }


        private IndexModel LoadData()
        {
            List<Model.Item> Lasted = API.SliderGet();
            var indexmodel = new IndexModel();
            indexmodel.Lasted = Lasted;
            return indexmodel;
        }
        

    }
}
