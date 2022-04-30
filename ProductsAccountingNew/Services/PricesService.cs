using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;


// Цены на продукты может изменять и удалять только администратор, просматривать могут все
namespace ProductsAccountingNew.Services
{
    public class PricesService
    {
        private static readonly List<Price> Prices = new List<Price>
        {
                new Price(Guid.NewGuid(), "Bread", 49),
                new Price(Guid.NewGuid(), "Tea", 150),
        };


        public IEnumerable<Price> GetPrices()
        {
            return Prices;
        }

        public void AddPrice(Price price)
        {
            if (Prices.Any(x => x.Name == price.Name))
                throw new ArgumentException("User with such name already exists.");
            Prices.Add(price);
        }

        public void UpdatePrice(Price price)
        {
            var existing = Prices.FirstOrDefault(x => x.Id == price.Id);
            if (existing == null)
                return;
            existing.Name = price.Name;
            existing.price = price.price;
        }

        public void DeletePrice(Guid id)
        {
            var existing = Prices.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Prices.Remove(existing);
        }
    }
}
