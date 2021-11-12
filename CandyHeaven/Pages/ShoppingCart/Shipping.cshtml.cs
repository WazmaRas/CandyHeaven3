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
        public string PaymentMethod { get; set; }

        public Models.Person Person { get; set; }
        // ändringar
        [BindProperty]
        public List<Models.Product> ShoppingCart { get; set; }
        [BindProperty]
        public string Frakt { get; set; }
        [BindProperty]
        public double FraktSum { get; set; }
        [BindProperty]
        public bool Confirm { get; set; } = false;



        [BindProperty]
        public double Sum { get; set; }

        public void OnGet()
        {
            ShoppingCart = Data.ShoppingCartManager.GetProducts();
            Sum = ShoppingCart.Sum(product => product.Price);

        }
       
       
       
            
        public void OnPost()

        {
                ShoppingCart = Data.ShoppingCartManager.GetProducts();
                Sum = ShoppingCart.Sum(product => product.Price);

                if (Frakt == "DHL")
                {
                    FraktSum = Sum + 39;
                }
                if (Frakt == "Instabox")
                {
                    FraktSum = Sum + 29;
                }
                if (Frakt == "Hämta i butik")
                {
                    FraktSum = Sum + 0;
                }
            
          

        }


    }
}



