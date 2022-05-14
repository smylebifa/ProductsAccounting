using System;

namespace ProductsAccountingNew.Models
{
    public class ShoppingList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Guid UserId { get; set; }


        public ShoppingList(Guid userId, string name, int count, int price)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Name = name;
            Count = count;
            Price = price;
        }

        public ShoppingList()
        {
            Id = Guid.NewGuid();
            UserId = Guid.NewGuid();            
        }

    }
}
