using System.Threading.Tasks;
using ExpenseTracker.Core.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Web.Controllers.Authentication
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
       
        public IActionResult Login(string returnUrl = "/")
        {
            var authenticationResponseDto = new AuthenticateRequestDto
            {
                ReturnUrl = returnUrl
            };

            return View(authenticationResponseDto);
        }

       
        
        /// <summary>
        /// Logout From  The  Application
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirectPreserveMethod("/");
        }

    }
}