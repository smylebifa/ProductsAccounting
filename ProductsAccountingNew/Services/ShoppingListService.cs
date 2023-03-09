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

        public IEnumerable<ShoppingList> GetShoppingList(string login)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Login == login).Id;

            var shoppingList = _dbContext.ShoppingList.ToList().FindAll(item => item.UserId == userId).ToArray();
            return shoppingList;
        }

        public void AddProduct(string login, string productName, int count)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Login == login).Id;

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

        public void DeleteProduct(string login, string productName)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Login == login).Id;

            var existing = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == productName && x.UserId == userId);
            if (existing == null)
                return;

            _dbContext.ShoppingList.Remove(existing);
            _dbContext.SaveChanges();
        }

        public void BuyProduct(string login, Guid productId, string productName, int count, int price)
        {
            var user = _dbContext.Users.ToList().Find(item => item.Login == login);

            var ProductInShoppingList = _dbContext.ShoppingList.FirstOrDefault(x => x.Name == productName && x.UserId == user.Id);

            var foundedProduct = _dbContext.ProductsOfUsers.FirstOrDefault(x => x.ProductName == productName && x.UserId == user.Id);

            if (user.Cash >= price * count)
            {
                if (foundedProduct != null)
                {
                    foundedProduct.Count += count;
                }

                else
                {
                    ProductOfUser newProduct = new ProductOfUser(Guid.NewGuid(), productName, count, user.Id);
                    _dbContext.ProductsOfUsers.Add(newProduct);
                }
                               

                user.Cash -= price * count;

                _dbContext.Users.Update(user);

                _dbContext.ShoppingList.Remove(ProductInShoppingList);

                _dbContext.SaveChanges();
            }
        }


        public int? GetBalance(string login)
        {
            return _dbContext.Users.ToList().Find(item => item.Login == login).Cash;
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
