using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
   public class EShopSolutionContextFactory : IDesignTimeDbContextFactory<EShopSolutionDBContext>
    {
        public EShopSolutionDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var connectionString = configuration.GetConnectionString("eShopSolution");

            var optionsBuilder = new DbContextOptionsBuilder<EShopSolutionDBContext>();
            optionsBuilder.UseMySql(connectionString);

            return new EShopSolutionDBContext(optionsBuilder.Options);
        }
    }
   
}
