using Microsoft.EntityFrameworkCore;
using ProductsAccountingNew.Models;

namespace ProductsAccountingNew.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<ProductWithPrice> ProductsWithPrice { get; set; } = null!;
        public DbSet<ProductOfUser> ProductsOfUser { get; set; } = null!;
        public DbSet<Person> Persons { get; set; } = null!;


    }
}
