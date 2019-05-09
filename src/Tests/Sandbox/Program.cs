using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VianorKyustendil.Data;
using VianorKyustendil.Data.Core;
using VianorKyustendil.Data.Models;

namespace Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{typeof(Program).Namespace} ({string.Join(" ", args)}) starts working...");
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(true);

            using (var serviceScope = serviceProvider.CreateScope())
            {
                serviceProvider = serviceScope.ServiceProvider;
                SandboxCode(serviceProvider);
            }
        }

        private static void SandboxCode(IServiceProvider serviceProvider)
        {
             
            var db = serviceProvider.GetService<VianorKyustendilContext>();
            Console.WriteLine(db.Users.Count());
            //TODO: Code here

            //var category = db.Categories.FirstOrDefault(x => x.Name == "variable");
            //if (category == null)
            //{
            //    category = new Category
            //    {
            //        Name = "variable"
            //    };
            //}


            //Alert : I dont need to add the new category manualy, ef core will detect if its a new obj and will do add it auto by itself !

            //var product = new Product
            //{
            //    Category = category,
            //    ProductName = "variable"
            //};

            //db.Products.Add(product);
            //db.SaveChanges();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            services.AddDbContext<VianorKyustendilContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(DbRepository<>));

        }

    }
}
