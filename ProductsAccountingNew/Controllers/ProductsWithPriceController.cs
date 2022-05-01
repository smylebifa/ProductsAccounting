using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;
using System.Linq;
using System;


namespace ProductsAccountingNew.Controllers
{
    public class ProductsWithPriceController : Controller
    {
        private readonly ILogger<ProductsWithPriceController> _logger;
        private readonly IProductsWithPriceService _productWithPriceService;

        public ProductsWithPriceController(ILogger<ProductsWithPriceController> logger, IProductsWithPriceService productWithPriceService)
        {
            _logger = logger;
            _productWithPriceService = productWithPriceService;
        }


        public ActionResult Index()
        {
            var productsWithPrice = _productWithPriceService.GetProductWithPrice();
            ViewBag.ProductsWithPrice = productsWithPrice;
            return View();
        }

        [HttpPost]
        public IActionResult ProductsWithPrice(ProductWithPrice productWithPrice)
        {
            _productWithPriceService.AddProductWithPrice(productWithPrice);
            return RedirectToAction(nameof(Index));
        }
       
        [HttpGet("/change_price/{id}")]
        public new IActionResult ProductWithPrice(Guid id)
        {
            var productWithPrice = _productWithPriceService.GetProductWithPrice().FirstOrDefault(x => x.Id == id);
            return View(productWithPrice);
        }

        [HttpPost("/change_price")]
        public IActionResult Edit(ProductWithPrice productWithPrice)
        {
            _productWithPriceService.UpdatePrice(productWithPrice);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_price/{id}")]
        public IActionResult Delete(Guid id)
        {
            _productWithPriceService.DeleteProductWithPrice(id);
            return Ok();
        }


    }
}
