using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Bakary_Shop.Data;
using Bakary_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bakary_Shop.Pages
{
    public class orderModel : PageModel
    {
        private readonly BakaryShopContext _context;

        public orderModel(BakaryShopContext context)
        {
            this._context = context;
        }
         public Product Product { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        [BindProperty, EmailAddress, Required(ErrorMessage = "Please Enter a valid Email"), Display(Name = "Your Email Adress")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage = "Please supply a shpping address"), Display(Name = "Shipping Address")]
        public string OrderShipping { get; set; }
        [BindProperty, Display(Name = "Quantity")]
        public int OrderQuantity { get; set; }
        public async Task OnGetAsync()
        {
            Product =await _context.Products.FindAsync(Id);
        }
        public async Task<IActionResult> OnPostAsync()
        { 
            Product= await _context.Products.FindAsync(Id);
            if (ModelState.IsValid)
            {
                var body = $"<p>Thank You , We Recevied Your Order for  {OrderQuantity} of Piceces  of {Product.Name}</p>" +
                  $"<p>Your Addess is : {OrderShipping}</p>" +
                  $"<p>Your Total Price is {OrderQuantity * Product.Price}</p>" +
                  "<p> <b>Your Order Will Delivered Without 60 Minutes </b></p>";
                using (var smtp = new SmtpClient())
                {
                    var googleCredential = new NetworkCredential
                    {
                        UserName = "itsharetest@gmail.com",
                        Password = "ahmed@itshare123"
                    };
                    smtp.Credentials = googleCredential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "BakaryApp - New Order";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("ahmed@gmail.com");
                    await smtp.SendMailAsync(message);
                }
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
      }
}
