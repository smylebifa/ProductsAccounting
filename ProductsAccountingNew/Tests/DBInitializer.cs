using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using ProductsAccountingNew.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAccountingNew.Tests
{
    public class DbInitializer
    {
        public static void Initialize(DbContextOptions<TestDbContext> options)
        {
            try
            {
                var dbContext = new TestDbContext(options);
                dbContext.Database.EnsureCreated();
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                TestContext.Out.WriteLine(e.Message);
            }
        }
    }
}
