using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;

namespace ProductsAccountingNew.Services
{
    public interface IProductsOfUsersService
    {
        public IEnumerable<ProductOfUser> GetProducts(Guid userId);

        public void AddProductToUser(ProductOfUser productOfUser);

        public void DeleteProduct(Guid id, Guid userId);
    }
}
