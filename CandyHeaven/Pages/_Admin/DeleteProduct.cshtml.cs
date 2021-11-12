using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class DeleteProductModel : PageModel
    {
        public List<Models.Product> Products = Data.ProductManager.Products;


        public void OnPost(int id)
        {
            if (id != 0)
            {
                Data.ProductManager.DeleteProduct(id);
                 

            }
        }
    }
}
