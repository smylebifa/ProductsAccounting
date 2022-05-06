using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Services
{
    public class UsersServiceInMemory : IUsersService
    {
        private static readonly List<User> Users = new List<User>
        {
                new User(Guid.NewGuid(), "Kolya", "kolya@mail.ru", 400),
                new User(Guid.NewGuid(), "Petya", "petya@mail.ru", 500),
                new User(Guid.NewGuid(), "Anya", "anya@mail.ru", 1000),
        };

        public IEnumerable<User> GetUsers()
        {
            return Users;
        }

        public void AddUser(User user)
        {
            if (Users.Any(x => x.Name == user.Name))
                throw new ArgumentException("User with such name already exists.");
            Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existing = Users.FirstOrDefault(x => x.Id == user.Id);
            if (existing == null)
                return;
            existing.Cash = user.Cash;
            existing.Email = user.Email;
            existing.Name = user.Name;
        }

        public void DeleteUser(Guid id)
        {
            var existing = Users.FirstOrDefault(x => x.Id == id);
            if (existing == null)
                return;
            Users.Remove(existing);
        }
    }
}
