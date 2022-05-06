using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Services
{
    public class ProductPricesService : IProductPricesService
    {
        private readonly TestDbContext _dbContext;

        public ProductPricesService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<ProductPrice> GetProductWithPrice()
        {
            return _dbContext.ProductPrices.ToArray();
        }

        public void AddProductWithPrice(ProductPrice price)
        {
            if (_dbContext.ProductPrices.Any(x => x.Name == price.Name))
                throw new ArgumentException("User with such name already exists.");

            _dbContext.ProductPrices.Add(price);
            _dbContext.SaveChanges();

        }

        public void UpdatePrice(ProductPrice price)
        {
            var existing = _dbContext.ProductPrices.FirstOrDefault(x => x.Id == price.Id);
            if (existing == null)
                return;

            existing.Name = price.Name;
            existing.Price = price.Price;

            _dbContext.SaveChanges();
        }

        public void DeleteProductWithPrice(Guid id)
        {
            var existing = _dbContext.ProductPrices.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            _dbContext.ProductPrices.Remove(existing);
            _dbContext.SaveChanges();
        }
    }
}
