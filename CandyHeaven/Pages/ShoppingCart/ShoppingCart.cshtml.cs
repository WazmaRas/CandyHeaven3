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
        public class ProductInCart
        {
            public ProductInCart(Models.Product newProduct)
            {
                Product = newProduct;
            }

            public Models.Product Product = new Models.Product();
            public int NumberOfProduct = 1;
        }


        [BindProperty]
        public List<Models.Product> ShoppingCart { get; set; }

        [BindProperty]
        //public List<Models.Product> ItemsInCart { get; set; } = new List<Models.Product>();
        
        public List<ProductInCart> ItemsInCart { get; set; } = new List<ProductInCart>();

        public string ItemMessage { get; set; }
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

            //foreach (var item in ShoppingCart)
            //{
            //    if (!ItemsInCart.Contains(item))
            //    {
            //        ItemsInCart.Add(item);
            //    }
            //}
            foreach (var item in ShoppingCart)
            {
                bool productAlreadyExists = false;
                foreach (var itemInCart in ItemsInCart)
                {
                    if (itemInCart.Product == item)
                    {
                        itemInCart.NumberOfProduct++;
                        productAlreadyExists = true;
                    }
                }
                if (!productAlreadyExists)
                {
                    ItemsInCart.Add(new ProductInCart(item));
                }
            }

            ItemMessage = ShoppingCart.Count == 1 ? "Vara" : "Varor";

            Sum = ShoppingCart.Sum(product => product.Price);
            Tax = Sum * Tax;
        }
    }
}
