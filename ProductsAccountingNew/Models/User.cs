using System;

namespace ProductsAccountingNew.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Login { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public int? Cash { get; set; }
        
        public User(Guid id, string? login, string? email, string? fullName, int? cash)
        {
            Id = id;
            Login = login;
            Email = email;
            FullName = fullName;
            Cash = cash;
        }

        public User()
        {
            Id = Guid.NewGuid();
        }

    }
}
