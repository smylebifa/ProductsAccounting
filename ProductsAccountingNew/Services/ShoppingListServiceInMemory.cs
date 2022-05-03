using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAccountingNew.Services
{
    public class ShoppingListServiceInMemory
    {
        private static readonly List<ShoppingList> ShoppingListOfAllUsers = new List<ShoppingList>
        {
                new ShoppingList(Guid.NewGuid(), "bread", 2, 40, Guid.NewGuid()),
                new ShoppingList(Guid.NewGuid(), "milk", 3, 100, Guid.NewGuid()),
                new ShoppingList(Guid.NewGuid(), "chocolate", 1, 150, Guid.NewGuid()),
        };

        public IEnumerable<ShoppingList> GetShoppingList(Guid userId)
        {
            return ShoppingListOfAllUsers.FindAll(item => item.UserId == userId);
        }

        public void AddProduct(ShoppingList shoppingList)
        {
            ShoppingListOfAllUsers.Add(shoppingList);
        }

        public void DeleteProduct(string name, Guid userId)
        {
            var existing = ShoppingListOfAllUsers.FirstOrDefault(x => x.Name == name);
            if (existing == null)
                return;
            ShoppingListOfAllUsers.Remove(existing);
        }

        public void BuyProduct(Guid id, string name, int count, int price, Guid userId)
        {
            var existing = ShoppingListOfAllUsers.FirstOrDefault(x => x.Name == name);
            if (existing == null)
                return;

            // ProductsOfUsersService.AddProductToUser(new ProductOfUser(id, name, count, userId));

            ShoppingListOfAllUsers.Remove(existing);
        }

        public void UpdateProduct(ShoppingList shoppingList)
        {
            var existing = ShoppingListOfAllUsers.FirstOrDefault(x => x.Name == shoppingList.Name);
            if (existing == null)
                return;

            existing.Name = shoppingList.Name;
            existing.Price = shoppingList.Price;
            existing.Count = shoppingList.Count;
        }

    }
}
