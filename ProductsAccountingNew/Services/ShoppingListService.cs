using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAccountingNew.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly TestDbContext _dbContext;

        public ShoppingListService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ShoppingList> GetShoppingList(Guid userId)
        {
            return _dbContext.ShoppingList.ToArray();
        }

        public void AddProduct(ShoppingList shoppingList)
        {
            _dbContext.ShoppingList.Add(shoppingList);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(Guid id, string name)
        {
            var existing = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == name);
            if (existing == null)
                return;

            _dbContext.ShoppingList.Remove(existing);
            _dbContext.SaveChanges();            
        }

        public void BuyProduct(Guid id, string name, int count, int price, Guid userId)
        {
            var existing = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == name);
            if (existing == null)
                return;

            _dbContext.ProductsOfUsers.Add(new ProductOfUser(id, name, count, userId));

            _dbContext.ShoppingList.Remove(existing);
            _dbContext.SaveChanges();

        }

        public void UpdateProduct(ShoppingList shoppingList)
        {
            var existing = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == shoppingList.Name);
            if (existing == null)
                return;

            existing.Name = shoppingList.Name;
            existing.Price = shoppingList.Price;
            existing.Count = shoppingList.Count;

            _dbContext.SaveChanges();

        }

    }
}
