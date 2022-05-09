﻿using ProductsAccountingNew.Data;
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

        public void AddProduct(string userName, ShoppingList shoppingList)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == userName).Id;

            shoppingList.UserId = userId;

            _dbContext.ShoppingList.Add(shoppingList);
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
            if (ProductInShoppingList == null)
                return;

            _dbContext.ShoppingList.Remove(ProductInShoppingList);

            var existing = _dbContext.ProductsOfUsers.FirstOrDefault(x => x.ProductName == productName && x.UserId == userId);
            if (existing == null)
                _dbContext.ProductsOfUsers.Add(new ProductOfUser(productId, productName, count, userId));
            else
            {
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == userId);

                if (user.Cash >= price * count)
                {
                    _dbContext.ProductsOfUsers.Remove(existing);
                    
                    existing.Count += count;

                    _dbContext.SaveChanges();

                    _dbContext.ProductsOfUsers.Add(existing);

                    
                    _dbContext.Users.Remove(user);

                    user.Cash -= price * count;

                    _dbContext.SaveChanges();

                    _dbContext.Users.Add(user);

                }
            }

            _dbContext.SaveChanges();

        }

    }
}
