using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;
using System;

namespace ProductsAccountingNew.Controllers
{
    public class ProductsOfUsersController : Controller
    {
        private readonly ILogger<ProductsOfUsersController> _logger;
        private readonly IProductsOfUsersService _productsService;
        public ProductsOfUsersController(ILogger<ProductsOfUsersController> logger, IProductsOfUsersService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }
        
        public IActionResult Index(Guid userId)
        {
            var products = _productsService.GetProducts(userId);
            ViewBag.ProductsOfUsers = products;
            return View();
        }

        [HttpPost]
        public IActionResult ProductsOfUsers(ProductOfUser productOfUser)
        {
            _productsService.AddProductToUser(productOfUser);
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
