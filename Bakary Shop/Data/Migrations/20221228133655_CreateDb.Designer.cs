﻿// <auto-generated />
using Bakary_Shop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bakary_Shop.Data.Migrations
{
    [DbContext(typeof(BakaryShopContext))]
    [Migration("20221228133655_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Bakary_Shop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnName("ImageFileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnName("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cake Cake",
                            ImageName = "product-2.jpg",
                            Name = "Cake",
                            Price = 44m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cookies Cookies",
                            ImageName = "about-2.jpg",
                            Name = "Bread",
                            Price = 44m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cookies Cookies",
                            ImageName = "carousel-1.jpg",
                            Name = "Cookies",
                            Price = 44m
                        },
                        new
                        {
                            Id = 4,
                            Description = "carousel carousel",
                            ImageName = "carousel-2.jpg",
                            Name = "carousel",
                            Price = 44m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cookies Cookies",
                            ImageName = "product-3.jpg",
                            Name = "Cookies",
                            Price = 44m
                        },
                        new
                        {
                            Id = 6,
                            Description = "carousel carousel",
                            ImageName = "product-4.jpg",
                            Name = "carousel",
                            Price = 44m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
