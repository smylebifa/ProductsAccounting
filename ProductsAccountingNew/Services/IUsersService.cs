using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;

namespace ProductsAccountingNew.Services
{
    public interface IUsersService
    {
        public IEnumerable<User> GetUsers();

        public bool AddUser(User user);

        public void UpdateUser(User user);

        public void UpdateUser(Guid id, string login, string fullName, string email, int cash);

        public void DeleteUser(Guid id);
        public bool IsUserExist(string status);
    }
}
