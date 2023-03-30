using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;

namespace StoryLibrary.Views.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IJSRuntime _jsRuntime;
        public async Task CallJavascriptMethod()
        {
         var result=   await _jsRuntime.InvokeAsync<object>("checkLoginState");
        }
    }
}
