using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages
{
    public class SortByPriceModel : PageModel
    {
        public List<Models.Product> Products { get; set; }
        public IEnumerable<double> Result { get; set; }
        public List<Models.Product> ShopCart { get; set; }
        // vi vill att Modelbinding ska ocsk� funka p� en get-request
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet(int id)
        {
            Products = Data.ProductManager.Search(SearchTerm);

            if (id != 0)
            {
                ShopCart = Data.ShoppingCartManager.AddToCart(id);

            }
            //Result = Products.OrderBy(prod => prod.Price));

        }
    }
}
