using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoryLibrary.Views.Pages;

namespace StoryLibrary.Views.Pages
{
    public class StoryModel : PageModel
    {
        public Model.Item Story { get; set; }
        public int NextPage { get; set; }
        public int PrevPage { get; set; }
        public string disablePrev { get; set; }
        public string disableNext { get; set; }

    }
}
