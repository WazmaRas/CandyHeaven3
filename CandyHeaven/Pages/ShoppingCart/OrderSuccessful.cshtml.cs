using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages.ShoppingCart
{
    public class OrderSuccessfulModel : PageModel
    {
        [BindProperty]
        public int Ordernumber{ get; set; }
        public List<Models.Product> ShoppingCart { get; set; }

        public void OnGet()
        {
            Random random = new Random();
            Ordernumber = random.Next(100000, 200000);

            ShoppingCart = Data.ShoppingCartManager.EmptyCart(ShoppingCart);

        }
    }
}
