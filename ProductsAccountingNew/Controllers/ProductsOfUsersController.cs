using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;
using System;

namespace ProductsAccountingNew.Controllers
{
    [Authorize]
    public class ProductsOfUsersController : Controller
    {
        private readonly ILogger<ProductsOfUsersController> _logger;
        private readonly IProductsOfUsersService _productsService;
        public ProductsOfUsersController(ILogger<ProductsOfUsersController> logger, IProductsOfUsersService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        public IActionResult Index()
        {
            string nameOfCurrentUser = User.Identity.Name;

            var products = _productsService.GetProducts(nameOfCurrentUser);
            ViewBag.ProductsOfUsers = products;
            return View();
        }

        [HttpPost]
        public IActionResult ProductsOfUsers(ProductOfUser productOfUser)
        {
            string nameOfCurrentUser = User.Identity.Name;

            _productsService.AddProductToUser(nameOfCurrentUser, productOfUser);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_product/{id}")]
        public IActionResult Delete(Guid id, Guid userId)
        {
            _productsService.DeleteProduct(id, userId);
            return Ok();
        }

    }
}
