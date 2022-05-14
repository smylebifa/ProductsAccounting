using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;

namespace ProductsAccountingNew.Services
{
    public interface IShoppingListService
    {
        public IEnumerable<ShoppingList> GetShoppingList(string userName);
        public void AddProduct(string userName, string productName, int count);
        public void DeleteProduct(string userName, string productName);
        public void BuyProduct(string userName, Guid productId, string productName, int count, int price);

        public List<string> GetProductNamesAndPrices();

        public int? GetBalance(string userName);

        
    }
}
