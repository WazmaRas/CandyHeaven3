using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages
{
    public class CandyShopModel : PageModel
    {

        public List<Models.ProductAPI> Products { get; set; }
        public List<Models.Product> ShopCart { get; set; }
        // vi vill att Modelbinding ska ocskå funka på en get-request
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        
        public void OnGet(int id)
        {
            var httpClient = new HttpClient();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var response = httpClient.GetAsync("https://localhost:44388/Shop").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            Products = JsonSerializer.Deserialize<List<Models.ProductAPI>>(apiResponse, options); 
           
            if (id != 0)
            {
                ShopCart = Data.ShoppingCartManager.AddToCart(id);
            }
        }
    }
}
