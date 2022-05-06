using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index(Guid userId)
        {
            var shoppingList = _shoppingListService.GetShoppingList(userId);
            ViewBag.ShoppingList = shoppingList;
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingList(ShoppingList shoppingList)
        {
            _shoppingListService.AddProduct(shoppingList);
            return RedirectToAction(nameof(Index));
        }

        
        [HttpPost("/shopping_list/buy_product/{id}/{name}/{count}/{price}/{userId}")]
        public IActionResult BuyProduct(Guid id, string name, int count, int price, Guid userId)
        {
            _shoppingListService.BuyProduct(id, name, count, price, userId);
            return Ok();
        }

        
        [HttpDelete("/shopping_list/delete_product/{id}/{name}")]
        public IActionResult Delete(Guid id, string name)
        {
            _shoppingListService.DeleteProduct(id, name);
            return Ok();
        }
    }
}
