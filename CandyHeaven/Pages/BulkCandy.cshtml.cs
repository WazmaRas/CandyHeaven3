using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages
{
    public class BulkCandyModel : PageModel
    {
        public List<Models.Product> Products { get; set; }
        public List<Models.Product> ShopCart { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public void OnGet(int id)
        {
            Products = Data.ProductManager.Search(SearchTerm);

            if (id != 0)
            {
                ShopCart = Data.ShoppingCartManager.AddToCart(id);
            }
        }
    }
}
