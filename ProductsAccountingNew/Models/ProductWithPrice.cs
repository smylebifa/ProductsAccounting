using System;

namespace ProductsAccountingNew.Models
{
    public class ProductWithPrice
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }

        public ProductWithPrice(Guid id, string? name, int? price)
        {
            Id = id;
            Name = name;            
            Price = price;
        }
        public ProductWithPrice()
        {
            Id = Guid.NewGuid();
        }
    }

    
}
