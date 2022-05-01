using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;


// Цены на продукты может изменять и удалять только администратор, просматривать могут все
namespace ProductsAccountingNew.Services
{
    public class ProductsWithPriceService : IProductsWithPriceService
    {
        private readonly TestDbContext _dbContext;

        public ProductsWithPriceService(TestDbContext dbContext)
        {
            _dbContext = dbContext;                       
        }


        public IEnumerable<ProductWithPrice> GetProductWithPrice()
        {
            return _dbContext.ProductsWithPrice.ToArray();
        }

        public void AddProductWithPrice(ProductWithPrice price)
        {            
            if (_dbContext.ProductsWithPrice.Any(x => x.Name == price.Name))
                throw new ArgumentException("User with such name already exists.");

            _dbContext.ProductsWithPrice.Add(price);
            _dbContext.SaveChanges();

        }

        public void UpdatePrice(ProductWithPrice price)
        {
            var existing = _dbContext.ProductsWithPrice.FirstOrDefault(x => x.Id == price.Id);
            if (existing == null)
                return;
            
            existing.Name = price.Name;
            existing.Price = price.Price;

            _dbContext.SaveChanges();
        }

        public void DeleteProductWithPrice(Guid id)
        {
            var existing = _dbContext.ProductsWithPrice.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            _dbContext.ProductsWithPrice.Remove(existing);
            _dbContext.SaveChanges();
        }
    }
}
