using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;
using System;
using System.Linq;


namespace ProductsAccountingNew.Controllers
{
    public class PricesController : Controller
    {
        private readonly ILogger<PricesController> _logger;
        private readonly PricesService _pricesService;

        public PricesController(ILogger<PricesController> logger, PricesService pricesService)
        {
            _logger = logger;
            _pricesService = pricesService;
        }


        public ActionResult Index()
        {
            var prices = _pricesService.GetPrices();
            ViewBag.Prices = prices;
            return View();
        }

        [HttpPost]
        public IActionResult Prices(Price priceList)
        {
            _pricesService.AddPrice(priceList);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/price_list/{id}")]
        public new IActionResult Price(Guid id)
        {
            var prices = _pricesService.GetPrices().FirstOrDefault(x => x.Id == id);
            return View(prices);
        }

        [HttpPost("/change_price")]
        public IActionResult Edit(Price priceList)
        {
            _pricesService.UpdatePrice(priceList);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_price/{id}")]
        public IActionResult Delete(Guid id)
        {
            _pricesService.DeletePrice(id);
            return Ok();
        }


    }
}
