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
            List<Model.Item> Lasted = API.TruyenMoiCapNhatGet();
            List<Model.Item> Hot = API.TruyenHotGet();
            var indexmodel = new IndexModel();
            indexmodel.Lasted = Lasted;
            indexmodel.Hot = Hot.FirstOrDefault();
            indexmodel.ListHot = Hot;
            return indexmodel;
        }
        

    }
}
