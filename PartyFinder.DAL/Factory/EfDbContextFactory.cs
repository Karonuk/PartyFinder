using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PartyFinder.DAL.Factory
{
    public class EfDbContextFactory : IDesignTimeDbContextFactory<EfDbContext>
    {
        public EfDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<EfDbContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new EfDbContext(optionsBuilder.Options);
        }
    }
}
