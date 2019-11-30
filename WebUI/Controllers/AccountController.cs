using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn([FromRoute] string scheme)
        {
            scheme ??= "oidc";
            var redirectUrl = Url.Content("~/");
            return Challenge(
                new AuthenticationProperties { RedirectUri = redirectUrl },
                scheme);
        }
    }
}
