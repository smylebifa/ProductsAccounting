using System;

namespace ProductsAccountingNew.Models
{
    public class ProductPrice
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }

        public ProductPrice(Guid id, string? name, int? price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public ProductPrice()
        {
            Id = Guid.NewGuid();
        }
    }
}
