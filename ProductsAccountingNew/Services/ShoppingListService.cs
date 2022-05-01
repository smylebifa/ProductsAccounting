using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAccountingNew.Services
{
    public class ShoppingListService
    {
        //private static readonly Dictionary<int, List<ShoppingList>> shoppingLists = new Dictionary<int, List<ShoppingList>>
        //{
        //    [1] = new List<ShoppingList> {
        //        new ShoppingList(Guid.NewGuid(), "bread", 2, 40, 1),
        //        new ShoppingList(Guid.NewGuid(), "milk", 3, 100, 1),
        //        new ShoppingList(Guid.NewGuid(), "chocolate", 1, 150, 1),
        //    },
        //};
                
        //public IEnumerable<ShoppingList> GetShoppingList(int user_id)
        //{
        //    user_id = 1;
        //    return shoppingLists[user_id];
        //}

        //public void AddProduct(string name, int count, int price, int user_id)
        //{
        //    user_id = 1;
        //    shoppingLists[user_id].Add(new ShoppingList(Guid.NewGuid(), name, count, price, user_id));
        //}

        //public void DeleteProduct(Guid id, int user_id)
        //{
        //    List<ShoppingList> shoppingList = shoppingLists[user_id];

        //    var existing = shoppingList.FirstOrDefault(x => x.Id == id);
        //    if (existing == null)
        //        return;           
        //    shoppingList.Remove(existing);
        //}

        //public void BuyProduct(Guid id, string name, int count, int price, Guid userId)
        //{
        //    List<ShoppingList> shoppingList = shoppingLists[user_id];

        //    var existing = shoppingList.FirstOrDefault(x => x.Id == id);
        //    if (existing == null)
        //        return;

        //    ProductsOfUserService.(id, new ProductWithPrice(name, count, price), userId);

        //    shoppingList.Remove(existing);
        //}

        //public void UpdateUser(int user_id, Guid product_id)
        //{
        //    List<ShoppingList> shoppingList = shoppingLists[user_id];

        //    var existing = shoppingList.FirstOrDefault(x => x.Id == product_id);
        //    if (existing == null)
        //        return;

        //    existing.Name = shoppingList[0].Name;
        //    existing.Price = shoppingList[0].Price;
        //    existing.Count = shoppingList[0].Count;
        //}

    }
}
