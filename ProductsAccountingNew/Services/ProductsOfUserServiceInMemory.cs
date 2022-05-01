using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

// У пользователя есть продукты в корзине, которые он может добавлять 
// в корзину из списка покупок shopping_list и удалять продукты из корзины
namespace ProductsAccountingNew.Services
{
    public class ProductOfUserService
    {
        private static readonly List<ProductOfUser> ProductsOfUser = new List<ProductOfUser>
        {
                new ProductOfUser(Guid.NewGuid(), "bread", 2, Guid.NewGuid()),
                new ProductOfUser(Guid.NewGuid(), "milk", 1, Guid.NewGuid()),
        };

        static public void AddProductToUser(ProductOfUser productOfUser)
        {
            ProductsOfUser.Add(productOfUser);
        }


        public IEnumerable<ProductOfUser> GetProducts(Guid userId)
        {
            return ProductsOfUser;
        }

        public void DeleteProduct(Guid id, Guid userId)
        {
            var existing = ProductsOfUser.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            ProductsOfUser.Remove(existing);
        }

    }
}
