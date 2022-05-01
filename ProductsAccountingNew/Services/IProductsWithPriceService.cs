using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;

namespace ProductsAccountingNew.Services
{
    public interface IProductsWithPriceService
    {
        public IEnumerable<ProductWithPrice> GetProductWithPrice();

        public void AddProductWithPrice(ProductWithPrice price);

        public void UpdatePrice(ProductWithPrice price);

        public void DeleteProductWithPrice(Guid id);
    }
}
