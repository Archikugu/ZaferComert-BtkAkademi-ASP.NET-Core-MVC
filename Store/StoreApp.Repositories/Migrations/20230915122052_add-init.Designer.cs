﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Repositories;

#nullable disable

namespace StoreApp.Repositories.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230915122052_add-init")]
    partial class addinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("StoreApp.Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Book"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Electronic"
                        });
                });

            modelBuilder.Entity("StoreApp.Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 2,
                            Price = 17000m,
                            ProductName = "Computer"
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 2,
                            Price = 1000m,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 2,
                            Price = 500m,
                            ProductName = "Mouse"
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 2,
                            Price = 7000m,
                            ProductName = "Monitor"
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 2,
                            Price = 1500m,
                            ProductName = "Deck"
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 1,
                            Price = 1500m,
                            ProductName = "Hamlet"
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 1,
                            Price = 1500m,
                            ProductName = "History"
                        });
                });

            modelBuilder.Entity("StoreApp.Entities.Models.Product", b =>
                {
                    b.HasOne("StoreApp.Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("StoreApp.Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}