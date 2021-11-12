using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages.ShoppingCart

{
    public class PaymentModel : PageModel
    {
        [BindProperty (SupportsGet =true)]
        public string Name { get; set; }
        [BindProperty]
        public string Frakt { get; set; }



        public void OnGet(int dhl)
        {
            
            
        }
        public void OnPost()
        {
          
        }
    }
}
