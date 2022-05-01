using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;


// Цены на продукты может изменять и удалять только администратор, просматривать могут все
namespace ProductsAccountingNew.Services
{
    public class IProductWithPriceServiceInMemory
    {
        private static readonly List<ProductWithPrice> Prices = new List<ProductWithPrice>
        {
                new ProductWithPrice(Guid.NewGuid(), "Bread", 49),
                new ProductWithPrice(Guid.NewGuid(), "Tea", 150),
        };


        public IEnumerable<ProductWithPrice> GetProductWithPrice()
        {
            return Prices;
        }

        public void AddProductWithPrice(ProductWithPrice price)
        {
            if (Prices.Any(x => x.Name == price.Name))
                throw new ArgumentException("User with such name already exists.");
            Prices.Add(price);
        }

        public void UpdatePrice(ProductWithPrice price)
        {
            var existing = Prices.FirstOrDefault(x => x.Id == price.Id);
            if (existing == null)
                return;
            existing.Name = price.Name;
            existing.Price = price.Price;
        }

        public void DeleteProductWithPrice(Guid id)
        {
            var existing = Prices.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Prices.Remove(existing);
        }
    }
}
