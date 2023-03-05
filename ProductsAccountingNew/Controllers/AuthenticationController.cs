using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly Services.AuthenticationService _authenticationService;

        public AuthenticationController(Services.AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet("/login")]
        public IActionResult Index(string status = "", string login = "", string password = "")
        {
            ViewBag.Status = status;
            ViewBag.Login = login;
            ViewBag.Password = password;

            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            var login = form["login"];
            var password = form["password"];

            if (!form.ContainsKey("login"))
            {
                return RedirectToAction("Index", "Authentication", new { status = "errorWithLogin", login = login });
            }

            if (!form.ContainsKey("password"))
            {
                return RedirectToAction("Index", "Authentication", new { status = "errorWithPassword", login = login });
            }

            if (_authenticationService.IsUserExist(login))
            {
                if (!_authenticationService.Login(login, password))
                {
                    return RedirectToAction("Index", "Authentication", new { status = "errorWithPassword", login = login, password = password });
                }
            }

            else
            {
                return RedirectToAction("Index", "Authentication", new { status = "errorWithLogin", login = login, password = password });
            }


            var claims = new List<Claim> { new Claim(ClaimTypes.Name, login) };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Home");

        }

        [HttpGet("/logout")]
        public async Task<IActionResult> Logout()
        {
            var context = HttpContext;
            await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Authentication");
        }

        [Authorize]
        [HttpGet("/authenticated")]
        public string IsAuthenticated()
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            if (string.IsNullOrEmpty(name))
            {
                // Код ошибки - не авторизован
                HttpContext.Response.StatusCode = 401;
                return string.Empty;
            }

            return name;
        }

        [HttpGet]
        public IActionResult RegisterPage(string status = "", string login = "")
        {
            ViewBag.Status = status;
            ViewBag.Login = login;

            // Передаем пользователю представление RegisterPage 
            return View();
        }

        [HttpPost]
        public IActionResult Register(string login, string password)
        {
            if (login == "" || login == null || _authenticationService.IsUserExist(login))
            {
                return RedirectToAction("RegisterPage", "Authentication", new { status = "errorWithLogin", login = login });
            }

            else
            {
                if (password == null || password == "")
                {
                    return RedirectToAction("RegisterPage", "Authentication", new { status = "success", login = login });
                }

                else
                {
                    _authenticationService.Register(login, password);
                    return RedirectToAction("Index");
                }

            }

        }
    }
}