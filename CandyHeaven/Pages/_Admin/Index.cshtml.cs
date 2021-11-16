using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class IndexModel : PageModel
    {
        //public List<Models.ProductAPI> Products = Data.ProductManager.Products;
        public List<Models.Product> Products { get; set; }

        public void OnGet(int id)
        {
            var httpClient = new HttpClient();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var response = httpClient.GetAsync("https://localhost:44388/Shop").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();


             Products = JsonSerializer.Deserialize<List<Models.Product>>(apiResponse, options);
            Data.ProductManager.Products = Products;
            if (id != 0)
            {
                Products = Data.ProductManager.DeleteProduct(id);
            }
        }
    }
}

