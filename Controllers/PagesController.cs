using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StoryLibrary.DB;
using StoryLibrary.Model;
using StoryLibrary.Pages;
using StoryLibrary.Views.Component;
using StoryLibrary.Views.Pages;

namespace StoryLibrary.Controllers
{
    public class PagesController : Controller
    {

        public IActionResult Category(string id)
        {
            var categoryModel = new CategoryModel();
            var Page = id.Split('-').Last();
            var catName = id.Replace("-" + id.Split('-').Last(), "");
            var result = API.CategoryGet(new CategoryParam { Alias = catName, Pages = Page == "0" ? "1" : Page });

            categoryModel.Category = result.CatPages[0].CatName;
            categoryModel.CatList = new List<Model.ListItemInCat>();
            categoryModel.CatList = result.ListItemInCat;
            categoryModel.TotalPage = result.TotalPages[0].PageCount;
            categoryModel.Alias = catName;
            var lastPage = result.TotalPages[0].PageCount / 12;
            if (Convert.ToInt32(Page) + 1 > lastPage)
            {
                categoryModel.disableNext = "disabled";
            }
            if (Convert.ToInt32(Page) - 1 <= 0)
            {
                categoryModel.disablePrev = "disabled";
            }


            categoryModel.NextPage = Convert.ToInt32(Page) + 1 >= lastPage ? lastPage : Convert.ToInt32(Page) + 1;
            categoryModel.PrevPage = Convert.ToInt32(Page) - 1 <= 0 ? 1 : Convert.ToInt32(Page) - 1;

            //Menu br = new Menu();
            //br.Invoke(result.CatPages[0].CatName);

            return View("Category", categoryModel);
        }

        public IActionResult Story(string id)
        {
            var Id = id.Split('-');
            Model.ListItem Story = API.ItemGet(Id.Last());
            var Storymodel = new StoryModel();
            Storymodel.Story = Story.Item[0];
            return View("Story", Storymodel);
        }
        public IActionResult ReadStory(string id)
        {
            var Id = id.Split('-');
            Chapter chap = API.ChapterGet(new ChapterParamGet { ID = Id[0].ToString(), ChapterID = (Convert.ToInt32(Id[1].ToString()) - 1).ToString() });
            ReadStoryModel rd = new ReadStoryModel();
            rd.ChapterName = chap.Name;
            rd.Detail = chap.Detail;
            rd.TitleTruyen = chap.TitleTruyen;
            rd.Alias = chap.Alias;
            rd.IDTruyen = Id[0].ToString();
            rd.PageChapter = "1";
            rd.TotalchapterPageCount = chap.TotalchapterPageCount;
            return View("ReadStory", rd);
        }
        public JsonResult LoadChapterList(string IDTruyen, string Page)
        {
            var result = API.ChapterListGet(new ListChapterParam { ID = IDTruyen, Page = Page });
            return Json(result);
        }
    }
}
