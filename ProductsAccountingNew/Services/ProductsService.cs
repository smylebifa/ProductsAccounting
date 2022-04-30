using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;

// У пользователя есть продукты в корзине, которые он может добавлять 
// в корзину из списка покупок shopping_list и удалять продукты из корзины
namespace ProductsAccountingNew.Services
{
    public class ProductsService
    {
        public static readonly Dictionary<int, List<Product>> UsersProductList = new Dictionary<int, List<Product>>
        {
            [1] = new List<Product> { new Product(Guid.NewGuid(), "bread", 2), 
                                      new Product(Guid.NewGuid(), "milk", 5) },
        };

        static public void AddProductToUser(Guid product_id, string name, int count, int user_id)
        {
            UsersProductList[user_id].Add(new Product(Guid.NewGuid(), name, count));
        }


        public IEnumerable<Product> GetProducts(int user_id)
        {
            return UsersProductList[user_id];
        }

        public void DeleteProduct(Guid id, int user_id)
        {
            List<Product> Products = UsersProductList[user_id];

            var existing = Products.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Products.Remove(existing);
        }

    }
}
