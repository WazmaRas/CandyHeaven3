using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class Bar: Product
    {
        public string Taste { get; set; }
        public Bar(string name, double price, string image, int id, bool chosen, int quantity, string productInfo, string taste) : base(name, price, image, id, chosen, quantity, productInfo)
        {
            Taste = taste;
        }
    }
}
