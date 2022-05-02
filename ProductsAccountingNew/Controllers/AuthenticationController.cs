using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public IActionResult Index()
        {
            // Передаем пользователю представление Index (берется из названия функции контроллера) 
            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            // Проверка на заполненность полей формы
            if (!form.ContainsKey("username") || !form.ContainsKey("password"))
                throw new UnauthorizedAccessException();

            var username = form["username"];
            var password = form["password"];

            if (!_authenticationService.Login(username, password))
                throw new InvalidOperationException();

            var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            
            return RedirectToAction("Index", "Users");
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
        public IActionResult RegisterPage()
        {
            // Передаем пользователю представление RegisterPage 
            return View();
        }

        [HttpPost]
        public IActionResult Register(string userName, string password)
        {
            _authenticationService.Register(userName, password);
            return RedirectToAction("Index");
        }
    }
}