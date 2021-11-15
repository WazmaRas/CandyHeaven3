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
        public string Catogory { get; set; }


        public void OnPost(int id)
        {
            Models.Product newProduct = new Models.BulkCandy(Id, Name, Description, Featured, Price, ImageURL, Stock, CandySort);

            Data.ProductManager.AddProduct(newProduct);

            







        }
    }
}
