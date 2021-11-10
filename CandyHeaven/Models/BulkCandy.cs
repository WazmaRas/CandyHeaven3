using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class BulkCandy : Product
    {

        public string CandySort { get; set; }
        public BulkCandy(string name, double price, string image, int id, bool chosen, int quantity, string productInfo, string candysort) : base(name, price, image, id, chosen, quantity, productInfo)
        {
            CandySort = candysort;
        }


    }
}
