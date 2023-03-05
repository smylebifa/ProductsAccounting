using System;

namespace ProductsAccountingNew.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}
