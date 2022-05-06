using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;

namespace ProductsAccountingNew.Controllers
{
    public class ProductPricesController : Controller
    {
        private readonly ILogger<ProductPricesController> _logger;
        private readonly IProductPricesService _productPriceService;

        public ProductPricesController(ILogger<ProductPricesController> logger, IProductPricesService productPriceService)
        {
            _logger = logger;
            _productPriceService = productPriceService;
        }


        public ActionResult Index()
        {
            var productsWithPrice = _productPriceService.GetProductWithPrice();
            ViewBag.ProductPrices = productsWithPrice;
            return View();
        }

        [HttpPost]
        public IActionResult ProductPrices(ProductPrice productPrice)
        {
            _productPriceService.AddProductWithPrice(productPrice);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/change_price/{id}")]
        public new IActionResult ProductPrice(Guid id)
        {
            var productWithPrice = _productPriceService.GetProductWithPrice().FirstOrDefault(x => x.Id == id);
            return View(productWithPrice);
        }

        [HttpPost("/change_price")]
        public IActionResult Edit(ProductPrice productWithPrice)
        {
            _productPriceService.UpdatePrice(productWithPrice);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_price/{id}")]
        public IActionResult Delete(Guid id)
        {
            _productPriceService.DeleteProductWithPrice(id);
            return Ok();
        }
    }
}