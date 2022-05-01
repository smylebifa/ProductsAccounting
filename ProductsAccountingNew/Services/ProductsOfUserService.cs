using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

// У пользователя есть продукты в корзине, которые он может добавлять 
// в корзину из списка покупок shopping_list и удалять продукты из корзины
namespace ProductsAccountingNew.Services
{
    public class ProductsOfUserService : IProductsOfUserService
    {
        private readonly TestDbContext _dbContext;

        public ProductsOfUserService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ProductOfUser> GetProducts(Guid userId)
        {
           return _dbContext.ProductsOfUser.ToArray();
        }

        public void AddProductToUser(ProductOfUser productOfUser)
        {
            _dbContext.ProductsOfUser.Add(productOfUser);
            _dbContext.SaveChanges();
        }


        public void DeleteProduct(Guid id, Guid userId)
        {
            var existing = _dbContext.ProductsOfUser.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;

            _dbContext.ProductsOfUser.Remove(existing);
            _dbContext.SaveChanges();
        }

    }
}
