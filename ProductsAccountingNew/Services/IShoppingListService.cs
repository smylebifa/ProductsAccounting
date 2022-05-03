using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Services
{
    public interface IShoppingListService
    {
        public IEnumerable<ShoppingList> GetShoppingList(Guid userId);
        public void AddProduct(ShoppingList shoppingList);
        public void DeleteProduct(Guid id, string name);
        public void BuyProduct(Guid id, string name, int count, int price, Guid userId);
        public void UpdateProduct(ShoppingList shoppingList);

    }
}
