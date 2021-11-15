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

        }
    }
}
