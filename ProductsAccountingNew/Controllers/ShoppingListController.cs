using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Models;
using ProductsAccountingNew.Services;
using System;

namespace ProductsAccountingNew.Controllers
{
    [Authorize]
    public class ShoppingListController : Controller
    {
        private readonly ILogger<ShoppingListController> _logger;
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(ILogger<ShoppingListController> logger, IShoppingListService shoppingListService)
        {
            _logger = logger;
            _shoppingListService = shoppingListService;
        }

        public IActionResult Index()
        {
            string userName = User.Identity.Name;

            var shoppingList = _shoppingListService.GetShoppingList(userName);
            ViewBag.ShoppingList = shoppingList;

            ViewBag.Balance = _shoppingListService.GetBalance(userName);

            var productNamesAndPrices = _shoppingListService.GetProductNamesAndPrices();

            ViewBag.ProductNames = new SelectList(productNamesAndPrices, "Name");


            return View();
        }

        [HttpPost]
        public IActionResult ShoppingList(ShoppingList shoppingList)
        {
            string userName = User.Identity.Name;
            _shoppingListService.AddProduct(userName, shoppingList.Name, shoppingList.Count);

            return RedirectToAction(nameof(Index));
        }


        [HttpPost("/shopping_list/buy_product/{productId}/{productName}/{count}/{price}")]
        public IActionResult BuyProduct(Guid productId, string productName, int count, int price)
        {
            string userName = User.Identity.Name;

            _shoppingListService.BuyProduct(userName, productId, productName, count, price);

            return Ok();
        }


        [HttpDelete("/shopping_list/delete_product/{productName}")]
        public IActionResult DeleteProduct(string productName)
        {
            string userName = User.Identity.Name;

            _shoppingListService.DeleteProduct(userName, productName);
            return Ok();
        }
    }
}
