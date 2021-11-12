using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class UpdateModel : PageModel

    {
        public List<Models.Product> Products { get; set; } = Data.ProductManager.Products;
        public string Changes { get; set; }
        public void OnGet(int id, string changes)
        {
            if(id != 0 && Changes != null)
            {
                Products = Data.ProductManager.UpdateProduct(5,Changes);
            }
        }
        public void OnPost(int id, string changes)
        {
            if (id != 0 && Changes != null)
            {
                Products = Data.ProductManager.UpdateProduct(5, Changes);
            }
        }

    }
}
