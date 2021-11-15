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
        public List<Models.Product> ShopCart { get; set; }

        public void OnGet(int id)
        {
            Products = Data.ProductManager.GetAllProducts();
            var chosenProducts = Products.Where(product => product.Featured == true).ToList();
            Products = chosenProducts;
            
            if (id != 0)
            {
                ShopCart = Data.ShoppingCartManager.AddToCart(id);
            }
        }
    }
}
