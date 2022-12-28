using Bakary_Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakary_Shop.Data
{
    public static class ModelBuilderExtentions
    {
       public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            Product[] products = {
            new Product
                {
                    Id = 1,
                    Name = "Cake",
                    Description = "Cake Cake",
                    ImageName = "product-2.jpg",
                    Price =44,
                },
             new Product
                {
                    Id = 2,
                    Name = "Bread",
                    Description = "Cookies Cookies",
                    ImageName = "about-2.jpg",
                    Price =44,
                },
             new Product
                {
                    Id = 3,
                    Name = "Cookies",
                    Description = "Cookies Cookies",
                    ImageName = "carousel-1.jpg",
                    Price =44,
                },
             new Product
                {
                    Id = 4,
                    Name = "carousel",
                    Description = "carousel carousel",
                    ImageName = "carousel-2.jpg",
                    Price =44,
                },
             new Product
                {
                    Id = 5,
                    Name = "Cookies",
                    Description = "Cookies Cookies",
                    ImageName = "product-3.jpg",
                    Price =44,
                },
             new Product
                {
                    Id = 6,
                    Name = "carousel",
                    Description = "carousel carousel",
                    ImageName = "service-1.jpg",
                    Price =44,
                },};
            modelBuilder.Entity<Product>().HasData(products) ;
           
            return modelBuilder;
        }
    }
}
