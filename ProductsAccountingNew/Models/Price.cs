using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Models
{
    public class Price
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? price { get; set; }

        public Price(Guid id, string? name, int? price)
        {
            Id = id;
            Name = name;
            this.price = price;
        }
        public Price()
        {
            Id = Guid.NewGuid();
        }
    }

    
}
