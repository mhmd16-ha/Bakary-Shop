using Bakary_Shop.Data.Cofigurations;
using Bakary_Shop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakary_Shop.Data
{
    public class BakaryShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configure DBContext to use sqlLite
            optionsBuilder.UseSqlite(@"Data Source=BakaryDb.db");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Applay Configuration 
            modelBuilder.ApplyConfiguration(new Configuration()).Seed();
        }
        public DbSet<Product> Products { get; set; }
    }
}
