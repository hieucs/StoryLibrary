using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using StoryLibrary.Model;
using StoryLibrary.Views.Pages;
using System.Text.Json;

namespace StoryLibrary.Views.Pages
{
    public class StoryModel : PageModel
    {
        public Model.Item Story { get; set; }
        public List<Item> Similar { get; set; }
        public List<Item> Random { get; set; }

        public int NextPage { get; set; }
        public int PrevPage { get; set; }
        public string disablePrev { get; set; }
        public string disableNext { get; set; }

    }
}
