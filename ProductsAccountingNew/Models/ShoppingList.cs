using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Models
{
    public class ShoppingList
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Count { get; set; }
        public int? Price { get; set; }
        public int? UserId { get; set; }

        public ShoppingList(Guid id, string? name, int? count, int? price, int? userId)
        {
            Id = id;
            Name = name;
            Count = count;
            Price = price;
            UserId = userId;
        }
        public ShoppingList()
        {
            Id = Guid.NewGuid();
        }

    }
}
