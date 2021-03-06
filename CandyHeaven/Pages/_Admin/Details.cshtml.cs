using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class DetailsModel : PageModel
    {

        public List<Models.Product> Products = Data.ProductManager.Products;
        public Models.Product Product { get; set; }

        public void OnGet(int id)
        {
            if (id != 0)
            {
                Product = Products.Where(product => product.Id == id).FirstOrDefault();
            }
        }
    }
}
