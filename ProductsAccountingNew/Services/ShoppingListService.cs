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

        public IEnumerable<ShoppingList> GetShoppingList(string nameOfUser)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == nameOfUser).Id;

            var shoppingList = _dbContext.ShoppingList.ToList().FindAll(item => item.UserId == userId).ToArray();
            return shoppingList;
        }

        public void AddProduct(string userName, string productName, int count)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == userName).Id;

            var productFound = _dbContext.ProductPrices.ToList().Find(item => item.Name == productName);

            if (productFound == null)
                return;

            var ProductInShoppingList = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == productName && x.UserId == userId);
            if (ProductInShoppingList == null)
            {
                ShoppingList shoppingList = new ShoppingList(userId, productName, count, productFound.Price);
                _dbContext.ShoppingList.Add(shoppingList);
            }

            else
            {
                _dbContext.ShoppingList.Remove(ProductInShoppingList);

                ProductInShoppingList.Count += count;

                _dbContext.SaveChanges();

                _dbContext.ShoppingList.Add(ProductInShoppingList);

            }
           
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(string userName, string productName)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == userName).Id;

            var existing = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == productName && x.UserId == userId);
            if (existing == null)
                return;

            _dbContext.ShoppingList.Remove(existing);
            _dbContext.SaveChanges();
        }

        public void BuyProduct(string userName, Guid productId, string productName, int count, int price)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == userName).Id;

            var ProductInShoppingList = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == productName && x.UserId == userId);
           

            var existing = _dbContext.ProductsOfUsers.FirstOrDefault(x => x.ProductName == productName && x.UserId == userId);
            if (existing == null)
                _dbContext.ProductsOfUsers.Add(new ProductOfUser(productId, productName, count, userId));
            else
            {
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == userId);

                if (user.Cash >= price * count)
                {
                    //_dbContext.ProductsOfUsers.Remove(existing);

                    existing.Count += count;

                    
                    //_dbContext.ProductsOfUsers.Add(existing);


                    _dbContext.Users.Remove(user);

                    _dbContext.SaveChanges();

                    user.Cash -= price * count;


                    _dbContext.Users.Add(user);

                    _dbContext.ShoppingList.Remove(ProductInShoppingList);

                    _dbContext.SaveChanges();

                }

            }

            _dbContext.SaveChanges();
        }


        public int? GetBalance(string userName)
        {
            return _dbContext.Users.ToList().Find(item => item.Name == userName).Cash;
        }

        public List<string> GetProductNamesAndPrices()
        {
            List<string> productName = new List<string>();

            foreach (var product in _dbContext.ProductPrices)
            {
                productName.Add(product.Name);
            }

            return productName;
        }

    }
}
