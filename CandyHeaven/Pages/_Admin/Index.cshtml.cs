using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class IndexModel : PageModel
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
        public string CandySort { get; set; }



        public void OnGet(int id)
        {

            if (id != 0)
            {
                Products = Data.ProductManager.DeleteProduct(id);

            }

        }

    }
}

