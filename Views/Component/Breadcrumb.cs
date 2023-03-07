using Microsoft.AspNetCore.Mvc;

namespace StoryLibrary.Views.Component
{
    public class Breadcrumb : ViewComponent
    {
        public string PageName { get; set; }
        public IViewComponentResult Invoke(string Page)
        {
            var breadcrumbModel = new Breadcrumb();
            breadcrumbModel.PageName = Page;
            return View(breadcrumbModel);
        }
    }
}
