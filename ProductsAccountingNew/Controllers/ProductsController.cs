using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Services;
using System;

namespace ProductsAccountingNew.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly ProductsService _productsService;
        public ProductsController(ILogger<ProductsController> logger, ProductsService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        public ActionResult Index()
        {
            int user_id = 1;
            var products = _productsService.GetProducts(user_id);
            ViewBag.Products = products;
            return View();
        }

        [HttpPost]
        public IActionResult Products()
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_product/{id}")]
        public IActionResult Delete(Guid id, int user_id)
        {
            user_id = 1;
            _productsService.DeleteProduct(id, user_id);
            return Ok();
        }

    }
}
