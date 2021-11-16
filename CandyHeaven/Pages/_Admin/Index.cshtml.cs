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
      
        public void OnGet(int id)
        {
            if (id != 0)
            {
                Products = Data.ProductManager.DeleteProduct(id);
            }
        }
    }
}

