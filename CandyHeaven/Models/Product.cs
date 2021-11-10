using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public bool Chosen { get; set; }
        public int StockQuantity { get; set; }
        public string ProductInfo { get; set; }



        public Product(string name, double price, string image, int id, bool chosen, int quantity, string productInfo)
        {
            Name = name;
            Price = price;
            ImageURL = image;
            Id = id;
            Chosen = chosen;
            StockQuantity = quantity;
            ProductInfo = productInfo;
        }
    }
}
