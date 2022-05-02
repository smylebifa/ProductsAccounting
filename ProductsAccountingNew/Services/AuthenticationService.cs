using ProductsAccountingNew.Data;
using ProductsAccountingNew.Models;
using System;
using System.Linq;


namespace ProductsAccountingNew.Services
{
    public class AuthenticationService
    {
        private readonly TestDbContext _dbContext;

        public AuthenticationService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Если имя пользователя найдено в базе, возвращаем его Id, иначе создаем нового пользователя
        public Guid Register(string userName, string password)
        {
            var person = _dbContext.Persons.FirstOrDefault(x => x.UserName == userName);
            if (person != null)
                return person.Id;

            var newPerson = new Person() { Id = Guid.NewGuid(), UserName = userName, Password = password };
            _dbContext.Persons.Add(newPerson);
            _dbContext.SaveChanges();
            return newPerson.Id;
        }

        // Проверяем существует ли пользователь в базе данных с таким именем, если существует проверяем совпадает ли пароль
        public bool Login(string userName, string password)
        {
            var person = _dbContext.Persons.FirstOrDefault(x => x.UserName == userName);
            if (person == null)
                return false;
            return person.Password == password;            
        }
    }
}
