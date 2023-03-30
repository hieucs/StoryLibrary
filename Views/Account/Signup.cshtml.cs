using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoryLibrary.Views.Account
{
    public class Signup : PageModel
    {
        public bool IsVerify { get; set; } = false;
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Pass { get; set; }
    }
}
