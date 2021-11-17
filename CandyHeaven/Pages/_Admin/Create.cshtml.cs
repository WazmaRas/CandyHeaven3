using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class CreateModel : PageModel
    {
        public List<Models.Product> Products = Data.ProductManager.Products;
        [BindProperty]
        [Required]
        public int Id { get; set; }
        [BindProperty]
        [Required]
        public string Name { get; set; }
        [BindProperty]
        [Required]
        public string Description { get; set; }
        [BindProperty]
        [Required]
        public double Price { get; set; }
        [BindProperty]
        [Required]
        public bool Featured { get; set; }
        [BindProperty]
        [Required]
        public int Stock { get; set; }
        [BindProperty]
        [Required]
        public string ImageURL { get; set; }
        [BindProperty]
        [Required]
        public string Taste { get; set; }
        [BindProperty]
        [Required]
        public int Weight { get; set; }
        [BindProperty]
        [Required]
        public string CandySort { get; set; }
        [BindProperty]
        public string Category { get; set; }

        public void OnPost()
        {
           

            
            
            if(CandySort != null && Weight != 0 )
            {
                Models.Product bulkCandy= new Models.BulkCandy(Id, Name, Description, Featured, Price, ImageURL, Stock, CandySort,Weight);
                Data.ProductManager.AddProduct(bulkCandy);
            }
            else if (Taste != null )
            {
                Models.Product bar = new Models.Bar(Id, Name, Description, Featured, Price, ImageURL, Stock, Taste);
                Data.ProductManager.AddProduct(bar);
            }
            else if (Weight != 0)
            {
                Models.Product candyBag = new Models.CandyBag(Id, Name, Description, Featured, Price, ImageURL, Stock, Weight);
                Data.ProductManager.AddProduct(candyBag);
            }
            else if(Weight == 0 && Taste == null && CandySort == null && Name != null)
            {
                Models.Product newProduct = new Models.Product(Id, Name, Description, Featured, Price, ImageURL, Stock);
                Data.ProductManager.AddProduct(newProduct);
            }
            var orderByID = Products.OrderBy(product => product.Id).LastOrDefault();
            Id = orderByID.Id;
            Id++;
          
            



        }
    }
}
