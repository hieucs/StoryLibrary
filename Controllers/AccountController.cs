using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using StoryLibrary.DB;
using StoryLibrary.Model;

namespace StoryLibrary.Controllers
{
    public class AccountController : Controller
    {
        public JsonResult AcountInfo(object result)
        {
            return Json(result);
        }
        [HttpPost]
        public IActionResult SignUp(string Email, string FullName, string Pass)
        {
            var s = new StoryLibrary.Views.Account.Signup();
            s.IsVerify = true;
            s.Email = Email;

            return View("Signup", s);
        }
        public IActionResult SignUp()
        {
            return View("Signup", new StoryLibrary.Views.Account.Signup());
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
