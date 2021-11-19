using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class EditModel : PageModel
    {
        public List<Models.Product> Products { get; set; } = Data.ProductManager.Products;
        public Models.Product Product { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public double Price { get; set; }

        [BindProperty]
        public bool Featured { get; set; }

        [BindProperty]
        public int Stock { get; set; }

        [BindProperty]
        public string ImageURL { get; set; }

        [BindProperty]
        public string CandySort { get; set; }

        public int Id { get; set; }

        public void OnGet(int id)
        {
            if (id != 0)
            {
                Product = Products.Where(product => product.Id == id).FirstOrDefault();
            }
        }
        public void OnPost(int id)
        {
            if (id != 0)
            {
                Product = Products.Where(product => product.Id == id).FirstOrDefault();
            }
            if (Name != null)
            {
                Product.Name = Name;
            }
            if (Price != 0)
            {
                Product.Price = Price;
            }
            if (Description != null)
            {
                Product.ProductInfo = Description;
            }
            if (Featured != false)
            {
                Product.Featured = Featured;
            }
            if (Stock != 0)
            {
                Product.StockQuantity = Stock;
            }
            if (ImageURL != null)
            {
                Product.ImageURL = ImageURL;
            }
           
        }
    }
}
