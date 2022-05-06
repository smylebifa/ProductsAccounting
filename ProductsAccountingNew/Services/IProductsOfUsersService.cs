using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;

namespace ProductsAccountingNew.Services
{
    public interface IProductsOfUsersService
    {
        public IEnumerable<ProductOfUser> GetProducts(string nameOfUser);

        public void AddProductToUser(string nameOfUser, ProductOfUser productOfUser);

        public void DeleteProduct(Guid id, Guid userId);
    }
}
