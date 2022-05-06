using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

// У пользователя есть продукты в корзине, которые он может добавлять 
// в корзину из списка покупок shopping_list и удалять продукты из корзины
namespace ProductsAccountingNew.Services
{
    public class ProductsOfUsersService : IProductsOfUsersService
    {
        private readonly TestDbContext _dbContext;

        public ProductsOfUsersService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ProductOfUser> GetProducts(string nameOfUser)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == nameOfUser).Id;

            var userProducts = _dbContext.ProductsOfUsers.ToList().FindAll(item => item.UserId == userId).ToArray();
            return userProducts;
        }

        public void AddProductToUser(string nameOfUser, ProductOfUser productOfUser)
        {
            var userId = _dbContext.Users.ToList().Find(item => item.Name == nameOfUser).Id;
            productOfUser.UserId = userId;

            _dbContext.ProductsOfUsers.Add(productOfUser);
            _dbContext.SaveChanges();
        }


        public void DeleteProduct(Guid id, Guid userId)
        {
            var existing = _dbContext.ProductsOfUsers.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;

            _dbContext.ProductsOfUsers.Remove(existing);
            _dbContext.SaveChanges();
        }

    }
}
