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



        [BindProperty]
        public string QuantityMessage { get; set; }
        [BindProperty]
        public double Sum { get; set; }



        /// <summary>
        /// ShoppingCart tilldelas värde av produkterna som finns i varukorgen i ShoppingCartManagern.
        ///
        /// </summary>
        /// <param name="addId"></param>
        /// <param name="removeId"></param>
        public void OnGet(int addId, int removeId)
        {
            ShoppingCart = Data.ShoppingCartManager.GetProducts();
            QuantityMessage = ShoppingCart.Count >= 1 ? "Vara" : "Varor";


            //if (addId != 0)
            //{
            //    ShoppingCart = Data.ShoppingCartManager.AddToCart(addId);
            //}
            //if (removeId != 0)
            //{
            //    ShoppingCart = Data.ShoppingCartManager.RemoveFromCart(removeId);
            //}
        }
        public void OnPost(int addId, int removeId)
        {
            ShoppingCart = Data.ShoppingCartManager.GetProducts();

            QuantityMessage = ShoppingCart.Count >= 1 ? "Vara" : "Varor";
            if (addId != 0)
            {
                ShoppingCart = Data.ShoppingCartManager.AddToCart(addId);
            }
            if (removeId != 0)
            {
                ShoppingCart = Data.ShoppingCartManager.RemoveFromCart(removeId);
            }
        }
    }
}
