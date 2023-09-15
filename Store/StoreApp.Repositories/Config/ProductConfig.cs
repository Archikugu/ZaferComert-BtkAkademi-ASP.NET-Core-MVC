using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductID = 1, CategoryID = 2, ProductName = "Computer", Price = 17_000 },
                new Product() { ProductID = 2, CategoryID = 2, ProductName = "Keyboard", Price = 1_000 },
                new Product() { ProductID = 3, CategoryID = 2, ProductName = "Mouse", Price = 500 },
                new Product() { ProductID = 4, CategoryID = 2, ProductName = "Monitor", Price = 7_000 },
                new Product() { ProductID = 5, CategoryID = 2, ProductName = "Deck", Price = 1_500 },
                new Product() { ProductID = 6, CategoryID = 1, ProductName = "Hamlet", Price = 1_500 },
                new Product() { ProductID = 7, CategoryID = 1, ProductName = "History", Price = 1_500 }
                );

        }
    }
}
