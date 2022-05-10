using System;

namespace ProductsAccountingNew.Models
{
    public class ProductOfUser
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public Guid UserId { get; set; }


        public ProductOfUser(Guid id, string productName, int count, Guid userId)
        {
            Id = id;
            ProductName = productName;
            Count = count;
            UserId = userId;
        }

        public ProductOfUser()
        {
            Id = Guid.NewGuid();
            UserId = Guid.NewGuid();
        }

    }
}
