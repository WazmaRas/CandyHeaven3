using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages.ShoppingCart
{
    public class ShippingModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        public string LastName { get; set; }

        [BindProperty]
        [Required]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        public string Adress { get; set; }
      
        [BindProperty]
        public List<Models.Product> ShoppingCart { get; set; }
        [BindProperty]
        public string Shipping { get; set; }
        [BindProperty]
        public string Payment { get; set; }
        [BindProperty]
        public double ShippingCost { get; set; }
     
        [BindProperty]
        public double Sum { get; set; }

        public void OnGet(string confirm)
        {
            ShoppingCart = Data.ShoppingCartManager.GetProducts();
            Sum = ShoppingCart.Sum(product => product.Price);
        }
 
        public void OnPost(string confirm)

        {
                ShoppingCart = Data.ShoppingCartManager.GetProducts();
                Sum = ShoppingCart.Sum(product => product.Price);

                if (Shipping == "DHL")
                {
                    ShippingCost = Sum + 39;
                }
                if (Shipping == "Instabox")
                {
                    ShippingCost = Sum + 29;
                }
                if (Shipping == "Hämta i butik")
                {
                    ShippingCost = Sum + 0;
                }
        }
    }
}



