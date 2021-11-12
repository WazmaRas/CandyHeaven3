using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandyHeaven.Pages._Admin
{
    public class IndexModel : PageModel
    {
        public List<Models.Product> Products = Data.ProductManager.Products;
        [BindProperty]
        [Required]
        public int Id { get; set; }      
        [BindProperty]
        [Required]
        public string Name { get; set; }     
        [BindProperty]
        [Required]
        public string Description { get; set; }    
        [BindProperty]
        [Required]
        public double Price { get; set; }    
        [BindProperty]
        [Required]
        public bool Featured { get; set; }     
        [BindProperty]
        [Required]
        public int Stock { get; set; }
        [BindProperty]
        [Required]
        public string ImageURL { get; set; }   
        [BindProperty]
        [Required]
        public string CandySort { get; set; }
        public List<Models.Product> AllProducts { get; set; } = Data.ProductManager.Products;
        public void OnPost()
        {
            Models.Product newProduct = new Models.BulkCandy(Id, Name, Description, Featured, Price, ImageURL, Stock, CandySort );

            Data.ProductManager.AddProduct(newProduct);
     

            //16, "Eget påhitt", "Ihoprullade godisremsor med mumsig jordgubbssmak att köpa hem lagom till storkalaset eller om du vill bunkra upp med massa godis så du har för ett par fredagsmystillfällen framöver.", false, 99.00, "https://www.barnorama.com/wp-content/uploads/2019/04/Funny-Pictures-1982-98.jpg", 25, "fantasiska ingrediens"KC
        }
    }
}
