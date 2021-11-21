using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class ProductInCart
    {
        public Models.Product Product = new Models.Product();
        public int NumberOfProduct = 1;
        public ProductInCart(Models.Product newProduct)
        {
            Product = newProduct;
        }
    }
}
