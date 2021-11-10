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
        public int Dhl { get; set; }
        public void OnGet(int dhl)
        {
            Dhl = dhl;
        }
    }
}