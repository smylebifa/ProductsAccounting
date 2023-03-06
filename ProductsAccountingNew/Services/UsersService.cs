using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


// Существует список пользователей, который доступен для просмотра и редактирования админом
namespace ProductsAccountingNew.Services
{
    public class UsersService : IUsersService
    {
        private readonly TestDbContext _dbContext;

        public UsersService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToArray();
        }

        public bool AddUser(User user)
        {
            if (_dbContext.Users.Any(x => x.Login == user.Login))
                return false;

            _dbContext.Users.Add(user);

            var salt = RandomString(10);
            var newPerson = new Person()
            {
                Id = user.Id,
                Login = user.Login,
                PasswordHash = Hash("" + salt),
                Salt = salt,
            };

            _dbContext.Persons.Add(newPerson);

            _dbContext.SaveChanges();

            return true;
        }

        public bool IsUserExist(string login)
        {
            var person = _dbContext.Users.FirstOrDefault(x => x.Login == login);

            if (person != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void UpdateUser(User user)
        {
            var existing = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);

            if (existing == null)
                return;

            existing.Login = user.Login;
            existing.FullName = user.FullName;
            existing.Email = user.Email;
            existing.Cash = user.Cash;

            _dbContext.SaveChanges();
        }

        public void UpdateUser(Guid id, string login, string fullName, string email, int cash)
        {
            var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);

            if (existing == null)
                return;

            existing.Login = login;
            existing.FullName = fullName;
            existing.Email = email;
            existing.Cash = cash;

            _dbContext.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var existing = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            var person = _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            if (existing == null)
                return;

            _dbContext.Users.Remove(existing);
            _dbContext.Persons.Remove(person);

            _dbContext.SaveChanges();
        }

        private string Hash(string password)
        {
            var algorithm = HashAlgorithm.Create("SHA256");
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(algorithm!.ComputeHash(passwordBytes));
        }

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
