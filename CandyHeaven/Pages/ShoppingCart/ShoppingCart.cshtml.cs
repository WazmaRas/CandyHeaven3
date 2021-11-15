using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages.ShoppingCart
{
    public class ShoppingCartModel : PageModel
    {
        public List<Models.Product> ShoppingCart { get; set; }
        public string ItemsInCart { get; set; }
        public double Sum { get; set; }
        public double Tax { get; set; } = 0.12;
        
        /// <summary>
        /// ShoppingCart tilldelas värde av produkterna som finns i varukorgen i ShoppingCartManagern.
        /// </summary>
        /// <param name="addId"></param>
        /// <param name="removeId"></param>
        public void OnGet(int addId, int removeId)
        {
            if (addId != 0)
            {
                ShoppingCart = Data.ShoppingCartManager.AddToCart(addId);
            }
            if (removeId != 0)
            {
                ShoppingCart = Data.ShoppingCartManager.RemoveFromCart(removeId);
            }
            ShoppingCart = Data.ShoppingCartManager.GetProducts();
            ItemsInCart = ShoppingCart.Count == 1 ? "Vara" : "Varor";
            Sum = ShoppingCart.Sum(product => product.Price);
            Tax = Sum * Tax;
        }
    }
}
