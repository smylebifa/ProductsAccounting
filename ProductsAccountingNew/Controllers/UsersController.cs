using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Services;
using ProductsAccountingNew.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace ProductsAccountingNew.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUsersService _usersService;
        private static string currentLogin;

        public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public ActionResult Index()
        {
            var users = _usersService.GetUsers();
            ViewBag.Users = users;
            ViewBag.Status = "";
            return View();
        }

       
        [HttpGet("/edit_user/{id}")]
        public new IActionResult ChangingUser(Guid id, string status = "")
        {
            var user = _usersService.GetUsers().FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                currentLogin = user.Login;
                ViewBag.Id = user.Id;
                ViewBag.Login = user.Login;
                ViewBag.Email = user.Email;
                ViewBag.FullName = user.FullName;
                ViewBag.Cash = user.Cash;
            }

            ViewBag.Status = status;

            return View();
        }

        [HttpPost("/edit_user")]
        public IActionResult Edit(Guid id, string login = "", string fullName = "", string email = "", int cash = 0)
        {
            bool isUserExist = _usersService.IsUserExist(login);

            if (isUserExist && currentLogin != login)
                return RedirectToAction("ChangingUser", "Users", new { id, status = "errorWithLogin" });

            else
            {
                _usersService.UpdateUser(id, login, fullName, email, cash);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/add_user")]
        public IActionResult User(string status = "", string login = "",  string fullName = "", string email = "", int cash = 0)
        {
            if (status == "errorWithLogin")
            {
                var users = _usersService.GetUsers();
                ViewBag.Status = "errorWithLogin";
                ViewBag.Users = users;

                ViewBag.Login = login;
                ViewBag.Email = email;
                ViewBag.FullName = fullName;
                ViewBag.Cash = cash;
            }

            return View();

        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            bool isUserExist = _usersService.IsUserExist(user.Login);

            if (isUserExist)
                return RedirectToAction("User", "Users", new { status = "errorWithLogin", 
                    login = user.Login, fullName = user.FullName, email = user.Email, cash = user.Cash }); 
         
            else
            {
                bool isUserAdded = _usersService.AddUser(user);
                return RedirectToAction(nameof(Index));
            }

        }

        [HttpDelete("/delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            _usersService.DeleteUser(id);
            return Ok();
        }
    }
}
