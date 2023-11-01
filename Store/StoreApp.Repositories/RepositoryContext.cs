using Microsoft.EntityFrameworkCore;
using StoreApp.Entities.Models;
using StoreApp.Repositories.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new ProductConfig());
            //modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
