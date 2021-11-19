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
        public bool Featured { get; set; }
        public int StockQuantity { get; set; }
        public string ProductInfo { get; set; }
        public int CartQuantity { get; set; }

        public Product() { }

        public Product(int id, string name, string description, bool featured, double price, string imageUrl, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageURL = imageUrl;
            Featured = featured;
            StockQuantity = stock;
            ProductInfo = description;
        }
    }
}
