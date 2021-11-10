using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class CandyBag : Models.Product
    {

        public int Weight { get; set; }
        public CandyBag(string name, double price, string image, int id, bool chosen, int quantity, string productInfo, int weight) : base(name, price, image, id, chosen, quantity, productInfo)
        {
            Weight = weight;
        }


    }
}
