using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;
using System;

namespace ProductsAccountingNew.Controllers
{
    public class ProductsOfUserController : Controller
    {
        private readonly ILogger<ProductsOfUserController> _logger;
        private readonly IProductsOfUserService _productsService;
        public ProductsOfUserController(ILogger<ProductsOfUserController> logger, IProductsOfUserService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }
        
        public IActionResult Index(Guid userId)
        {
            var products = _productsService.GetProducts(userId);
            ViewBag.ProductsOfUser = products;
            return View();
        }

        [HttpPost]
        public IActionResult ProductsOfUser(ProductOfUser productOfUser)
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
