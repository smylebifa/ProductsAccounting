using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public int? user_id { get; set; }


        public Product(Guid id, string? name, int? price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product()
        {
            Id = Guid.NewGuid();
        }

    }
}
