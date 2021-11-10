using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Data
{
    public class ShoppingCartManager
    {
        public static List<Models.Product> ShopCart { get; set; } = GetProducts();



        public static List<Models.Product> Products { get; set; } = ProductManager.GetAllProducts();
        public static Models.Product Product { get; set; }



        public static List<Models.Product> GetProducts()
        {
            if (ShopCart == null || !ShopCart.Any())
            {
                ShopCart = new List<Models.Product>();



            }



            return ShopCart;
        }
        public static List<Models.Product> AddToCart(int id)



        {



            Product = Products.Where(product => product.Id == id).FirstOrDefault();



            ShopCart.Add(Product);



            return ShopCart;
        }
        public static List<Models.Product> RemoveFromCart(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }



            Product = Products.Where(product => product.Id == id).FirstOrDefault();



            if (Product != null)
            {
                ShopCart.Remove(Product);
            }
            return ShopCart;



        }
        /// <summary>
        /// Empty shoppingcart
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public static List<Models.Product> EmptyCart(List<Models.Product> products)
        {
            ShopCart = null;
            return ShopCart;
        }


        private static List<Models.Product> NotFound()
        {
            throw new NotImplementedException();
        }
    }
}
