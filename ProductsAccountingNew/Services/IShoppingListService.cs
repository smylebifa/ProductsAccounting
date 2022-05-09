using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Services
{
    public interface IShoppingListService
    {
        public IEnumerable<ShoppingList> GetShoppingList(string userName);
        public void AddProduct(string userName, ShoppingList shoppingList);
        public void DeleteProduct(string userName, string productName);
        public void BuyProduct(string userName, Guid productId, string productName, int count, int price);

    }
}
