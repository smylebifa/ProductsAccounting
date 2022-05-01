using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAccountingNew.Services;
using System;

namespace ProductsAccountingNew.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly ILogger<ShoppingListController> _logger;
        private readonly ShoppingListService _shoppingListService;

        public ShoppingListController(ILogger<ShoppingListController> logger, ShoppingListService shoppingListService)
        {
            _logger = logger;
            _shoppingListService = shoppingListService;
        }

        public ActionResult Index()
        {
            // int user_id = 1;
            // var shoppingList = _shoppingListService.GetShoppingList(user_id);
            // ViewBag.ShoppingList = shoppingList;
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingList(string name, int count, int price, int user_id)
        {
           // _shoppingListService.AddProduct(name, count, price, user_id);
            return RedirectToAction(nameof(Index));
        }

        
        [HttpPost("/shopping_list/add_product/{id}/{name}/{count}/{user_id}")]
        public IActionResult Add(Guid id, string name, int count, int user_id)
        {
            // user_id = 1;
            // _shoppingListService.BuyProduct(id, name, count, user_id);
            return Ok();
        }

        
        [HttpDelete("/shopping_list/delete_product/{id}/{name}")]
        public IActionResult Delete(Guid id, int user_id)
        {
            // user_id = 1;
            //  _shoppingListService.DeleteProduct(id, user_id);
            return Ok();
        }
    }
}
