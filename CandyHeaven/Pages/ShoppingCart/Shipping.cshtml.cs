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

        public Models.Person person { get; set; } 
        public void OnGet()
        {

        }
        public void OnPost()
        {
            person = Data.PersonManager.GetPerson(Name, LastName, Email, Adress);
        }
    }
}
