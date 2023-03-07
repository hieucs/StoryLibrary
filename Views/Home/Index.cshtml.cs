using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoryLibrary.Views.Component;
using StoryLibrary.DB;

namespace StoryLibrary.Pages
{
    public class IndexModel : PageModel
    {
        public List<Model.Item> Lasted { get; set; }

    }
}