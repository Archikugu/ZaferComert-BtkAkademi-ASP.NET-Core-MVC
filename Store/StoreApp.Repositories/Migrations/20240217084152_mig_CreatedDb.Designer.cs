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
    [Migration("20240217084152_mig_CreatedDb")]
    partial class mig_CreatedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("StoreApp.Entities.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartLineID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartLine");
                });

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

            modelBuilder.Entity("StoreApp.Entities.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<bool>("GiftWrap")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Line2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Line3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Shipped")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StoreApp.Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ShowCase")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 2,
                            ImageUrl = "/images/1.jpg",
                            Price = 17000m,
                            ProductName = "Computer",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 2,
                            ImageUrl = "/images/2.jpg",
                            Price = 1000m,
                            ProductName = "Keyboard",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 2,
                            ImageUrl = "/images/3.jpg",
                            Price = 500m,
                            ProductName = "Mouse",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 2,
                            ImageUrl = "/images/4.jpg",
                            Price = 7000m,
                            ProductName = "Monitor",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 2,
                            ImageUrl = "/images/5.jpg",
                            Price = 1500m,
                            ProductName = "Deck",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 1,
                            ImageUrl = "/images/6.jpg",
                            Price = 25m,
                            ProductName = "History",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 1,
                            ImageUrl = "/images/7.jpg",
                            Price = 45m,
                            ProductName = "Hamlet",
                            ShowCase = false,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 1,
                            ImageUrl = "/images/8.jpg",
                            Price = 145m,
                            ProductName = "A Doll's House",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 9,
                            CategoryID = 1,
                            ImageUrl = "/images/9.jpg",
                            Price = 4445m,
                            ProductName = "Blindness",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 10,
                            CategoryID = 1,
                            ImageUrl = "/images/10.jpg",
                            Price = 545m,
                            ProductName = "Boston",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 11,
                            CategoryID = 1,
                            ImageUrl = "/images/11.jpg",
                            Price = 385m,
                            ProductName = "War and Piece",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 12,
                            CategoryID = 1,
                            ImageUrl = "/images/12.jpg",
                            Price = 845m,
                            ProductName = "The Sound of the Mountain",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 13,
                            CategoryID = 1,
                            ImageUrl = "/images/13.jpg",
                            Price = 415m,
                            ProductName = "The Idiot",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 14,
                            CategoryID = 1,
                            ImageUrl = "/images/14.jpg",
                            Price = 325m,
                            ProductName = "The Trial",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 15,
                            CategoryID = 1,
                            ImageUrl = "/images/15.jpg",
                            Price = 99m,
                            ProductName = "Masnavi",
                            ShowCase = true,
                            Summary = ""
                        },
                        new
                        {
                            ProductID = 16,
                            CategoryID = 1,
                            ImageUrl = "/images/16.jpg",
                            Price = 199m,
                            ProductName = "The Magic Mountain",
                            ShowCase = false,
                            Summary = ""
                        });
                });

            modelBuilder.Entity("StoreApp.Entities.Models.CartLine", b =>
                {
                    b.HasOne("StoreApp.Entities.Models.Order", null)
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");

                    b.HasOne("StoreApp.Entities.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
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

            modelBuilder.Entity("StoreApp.Entities.Models.Order", b =>
                {
                    b.Navigation("Lines");
                });
#pragma warning restore 612, 618
        }
    }
}