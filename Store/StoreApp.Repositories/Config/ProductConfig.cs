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
                new Product() { ProductID = 1, CategoryID = 2, ImageUrl = "/images/1.jpg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductID = 2, CategoryID = 2, ImageUrl = "/images/2.jpg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { ProductID = 3, CategoryID = 2, ImageUrl = "/images/3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductID = 4, CategoryID = 2, ImageUrl = "/images/4.jpg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                new Product() { ProductID = 5, CategoryID = 2, ImageUrl = "/images/5.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductID = 6, CategoryID = 1, ImageUrl = "/images/6.jpg", ProductName = "History", Price = 25, ShowCase = false },
                new Product() { ProductID = 7, CategoryID = 1, ImageUrl = "/images/7.jpg", ProductName = "Hamlet", Price = 45, ShowCase = false },
                new Product() { ProductID = 8, CategoryID = 1, ImageUrl = "/images/8.jpg", ProductName = "A Doll's House", Price = 145, ShowCase = true },
                new Product() { ProductID = 9, CategoryID = 1, ImageUrl = "/images/9.jpg", ProductName = "Blindness", Price = 4445, ShowCase = true },
                new Product() { ProductID = 10, CategoryID = 1, ImageUrl = "/images/10.jpg", ProductName = "Boston", Price = 545, ShowCase = true },
                new Product() { ProductID = 11, CategoryID = 1, ImageUrl = "/images/11.jpg", ProductName = "War and Piece", Price = 385, ShowCase = true },
                new Product() { ProductID = 12, CategoryID = 1, ImageUrl = "/images/12.jpg", ProductName = "The Sound of the Mountain", Price = 845, ShowCase = true },
                new Product() { ProductID = 13, CategoryID = 1, ImageUrl = "/images/13.jpg", ProductName = "The Idiot", Price = 415, ShowCase = true },
                new Product() { ProductID = 14, CategoryID = 1, ImageUrl = "/images/14.jpg", ProductName = "The Trial", Price = 325, ShowCase = true },
                new Product() { ProductID = 15, CategoryID = 1, ImageUrl = "/images/15.jpg", ProductName = "Masnavi", Price = 99, ShowCase = true },
                new Product() { ProductID = 16, CategoryID = 1, ImageUrl = "/images/16.jpg", ProductName = "The Magic Mountain", Price = 199, ShowCase = false }
                );

        }
    }
}
