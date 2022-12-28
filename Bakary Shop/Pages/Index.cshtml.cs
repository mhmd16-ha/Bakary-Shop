using Bakary_Shop.Data;
using Bakary_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakary_Shop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakaryShopContext _context;

        public IndexModel(BakaryShopContext context)
        {
            this._context = context;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public Product FeaturedProduct { get; set; }
        public async Task  OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count()));
        }
    }
}
