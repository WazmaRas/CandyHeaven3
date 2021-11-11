using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class Bar: Product
    {
        public string Taste { get; set; }
        public Bar(int id, string name, string description, bool featured, double price, string imageUrl, int stock, string taste) : base(id, name, description, featured, price, imageUrl, stock)
        {
            Taste = taste;
        }
    }
}
