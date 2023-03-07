using Microsoft.AspNetCore.Mvc;
using StoryLibrary.DB;

namespace StoryLibrary.Views.Component
{
    public class Menu : ViewComponent
    {
        public  List<Model.MenuItem> menus;
        public string PageName;
        public IViewComponentResult Invoke(string PageName)
        {
            if (PageName == null)
            {
                PageName = "Trang chủ";
            }    
            var model = new StoryLibrary.Views.Component.Menu();
            model.menus= API.MenuGet();
            model.PageName = PageName;
            return View(model);
        }
    }
}
