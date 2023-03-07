using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoryLibrary.Views.Pages
{
    public class CategoryModel : PageModel
    {
        public string Category { get; set; }
        public List<Model.ListItemInCat> CatList { get; set; }
        public int TotalPage { get; set; }
        public string Alias { get; set; }
        public int NextPage { get; set; }
        public int PrevPage { get; set; }
        public string disablePrev { get; set; }
        public string disableNext { get; set; }
    }
}
