using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ProductsAccountingNew.Data;

namespace ProductsAccountingNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args);
            var app = host.Build();
            DbInitializer.InitializeDb(app);
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
