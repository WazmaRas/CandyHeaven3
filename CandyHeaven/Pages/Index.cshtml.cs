using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Pages
{
    public class IndexModel : PageModel
    {
        public List<Models.Product> Products { get; set; } 
        
        public void OnGet(int id)
        {
            Products = Data.ProductManager.GetAllProducts();
            var chosenProducts = Products.Where(product => product.Chosen == true).ToList();
            Products = chosenProducts;


            //använder inte result?
            var result = Products.Where(prod => prod.Id == id).FirstOrDefault();

        }
    }
}
