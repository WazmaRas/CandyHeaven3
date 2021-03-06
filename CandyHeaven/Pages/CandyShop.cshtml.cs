using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages
{
    public class CandyShopModel : PageModel
    {

        public List<Models.Product> Products { get; set; } = Data.ProductManager.Products;
        public List<Models.Product> ShopCart { get; set; }
        // vi vill att Modelbinding ska ocsk? funka p? en get-request
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        
        public void OnGet(int id)
        {
            var sortByName = Products.OrderBy(prod => prod.Name).ToList();
            
            if (SearchTerm != null)
            {
                Products = Data.ProductManager.Search(SearchTerm);
            }

            if (id != 0)
            {
                ShopCart = Data.ShoppingCartManager.AddToCart(id);
            }
        }
    }
}
