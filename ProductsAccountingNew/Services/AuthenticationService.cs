using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ProductsAccountingNew.Services
{
    public class AuthenticationService
    {
        private readonly TestDbContext _dbContext;

        public AuthenticationService(IUsersService service, TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Если имя пользователя найдено в базе, возвращаем его Id, иначе создаем нового пользователя
        public Guid Register(string userName, string password)
        {

            var person = _dbContext.Persons.FirstOrDefault(x => x.UserName == userName);
            if (person != null)
                return person.Id;

            var salt = RandomString(10);

            Guid Id = Guid.NewGuid();
            
            var newPerson = new Person () { Id = Id, UserName = userName, PasswordHash = Hash(password + salt), Salt = salt };

            _dbContext.Persons.Add(newPerson);

            _dbContext.Users.Add(new User(Id, userName, "", 0));

            _dbContext.SaveChanges();
            return newPerson.Id;
        }

        // Проверяем существует ли пользователь в базе данных с таким именем, если существует проверяем совпадает ли пароль
        public bool Login(string userName, string password)
        {
            var person = _dbContext.Persons.FirstOrDefault(x => x.UserName == userName);
            if (person == null)
                return false;

            return person.PasswordHash == Hash(password + person.Salt);
        }

        // Вычисляем хеш по паролю с помощью криптографического алгоритма SHA256 
        private string Hash(string password)
        {
            var algorithm = HashAlgorithm.Create("SHA256");
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(algorithm!.ComputeHash(passwordBytes));
        }

        // Генерируем рандомную строку заданной длины
        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
