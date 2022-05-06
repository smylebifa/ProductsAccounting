using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Services
{
    public interface IProductPricesService
    {
        public IEnumerable<ProductPrice> GetProductWithPrice();

        public void AddProductWithPrice(ProductPrice price);

        public void UpdatePrice(ProductPrice price);

        public void DeleteProductWithPrice(Guid id);
    }
}
