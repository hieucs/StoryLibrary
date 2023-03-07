using Microsoft.AspNetCore.Mvc.RazorPages;
using StoryLibrary.Model;

namespace StoryLibrary.Views.Pages
{
    public class ReadStoryModel : PageModel
    {
        public string ChapterName { get; set; }
        public string TitleTruyen { get; set; }
        public string Alias { get; set; }
        public string Detail { get; set; }
        public string IDTruyen { get; set; }
        public List<Chapter> chapters { get; set; }
        public string PageChapter { get; set; }
        public string TotalchapterPageCount { get; set; }
    }
}
