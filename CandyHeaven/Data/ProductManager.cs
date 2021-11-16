using CandyHeaven.Models;
using System.Collections.Generic;
using System.Linq;

namespace CandyHeaven.Data
{
    public class ProductManager
    {
        public static Models.Product Product { get; set; }
        public static List<Models.Product> Products { get; set; } = GetAllProducts();
        /// <summary>
        /// Method to get all products
        /// </summary>
        /// <returns></returns>
        public static List<Models.Product> GetAllProducts()
        {
            if (Products == null || !Products.Any())
            {
                Products = new List<Models.Product>();

                Products.Add(new Models.Bar(1, "Barmony Salted Caramel", "En balanserad snackbar av nötter med inslag av salted caramel.", false, 17.00, "https://candypeople.se/wp-content/uploads/2020/06/barmony-caramel-300x232.jpg", 100, "Saltkaramel"));
                Products.Add(new Models.Bar(2, "Barmony Pecan/Sea Salt", "En balanserad snackbar av nötter.", false, 17.00, "https://candypeople.se/wp-content/uploads/2019/05/barmony_pecan-300x232.jpg", 100, "Pecan/seasalt"));
                Products.Add(new Models.Bar(3, "Barmony Salty Chocolate", "En balanserad snackbar av nötter med chokladdragerad undersida.", false, 17.00, "https://candypeople.se/wp-content/uploads/2019/05/barmony_saly_chocolate-300x232.jpg", 100, "Saltchoklad"));
                Products.Add(new Models.Bar(4, "Flapjack Berrylicious", "En bakad bar gjord av främst havre och sirap med inslag av torkade bär.", false, 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50387_Flapjack_berry-300x232.jpg", 100, "Bärsmak"));
                Products.Add(new Models.Bar(5, "Flapjack Pistachio", "En bakad bar gjord av främst havre och sirap med inslag av pistachnöt.", false, 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50385_flapjack_pistachio-300x232.jpg", 100, "Pistage"));
                Products.Add(new Models.Bar(6, "Flapjack Dark Chocolate", "En balanserad snackbar av nötter med chokladdragerad undersida.", false, 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50385_flpajack_darkchocolate-300x232.jpg", 100, "Saltchoklad"));
                Products.Add(new Models.CandyBag(7, "Frukttoppar", "Dragerat skumgodis med smak av jordgubbe, päron och persika/aprikos.", true, 15.90, "https://candypeople.se/wp-content/uploads/2017/10/113300_Frukttoppar_140g_utan_logga-300x232.jpg", 100, 140));
                Products.Add(new Models.CandyBag(8, "Jordnötsringar", "Krispiga jordnötsringar doppade i mjölkchoklad.", true, 29.90, "https://candypeople.se/wp-content/uploads/2020/11/50420_Chokladdoppade_Jordn%C3%B6tsringar-300x232.jpg", 100, 100));
                Products.Add(new Models.CandyBag(9, "S-märken Supersurt", "S-märken är ett gelegodis med supersurt sockeröverdrag.", true, 9.90, "https://candypeople.se/wp-content/uploads/2015/09/supersurt-300x225.jpg", 25, 80));
                Products.Add(new Models.CandyBag(10, "S-märken Supersalt", "S-märke Supersalt är en lakritsgelegodis med supersalt överdrag.", false, 9.90, "https://candypeople.se/wp-content/uploads/2015/09/supersalt-300x225.jpg", 25, 80));
                Products.Add(new Models.CandyBag(11, "Sura Colanappar", "Sura vingumminappar med en riklig smak utav cola tillsammans med syrligt sockeröverdrag. Produkten är vegansk.", false, 9.90, "https://candypeople.se/wp-content/uploads/2017/10/50135_Originals_SuraColanappar_80g-300x232.jpg", 25, 80));
                Products.Add(new Models.BulkCandy(12, "Smultronmatta", "", false, 99.00, "https://candypeople.se/wp-content/uploads/2015/04/smultron_matta-300x225.jpg", 25, "Smultron", 2.0));
                Products.Add(new Models.BulkCandy(13, "Sötlakritsmatta", "", true, 159.00, "https://candypeople.se/wp-content/uploads/2015/04/lakrits_matta-300x225.jpg", 25, "Sötlakrits", 2.0));
                Products.Add(new Models.BulkCandy(14, "Lakritsbitar", "Ibland är allt som krävs för en lyckad kväll 2.2 kg lakrits i storpack! Säkra din låda redan idag så du inte sitter lakritslös på lördag!", false, 199.00, "https://candypeople.se/wp-content/uploads/2015/04/lakrits_bitar-300x225.jpg", 25, "Lakrits", 2.2));
                Products.Add(new Models.BulkCandy(15, "Jordgubbsrolls", "Ihoprullade godisremsor med mumsig jordgubbssmak att köpa hem lagom till storkalaset eller om du vill bunkra upp med massa godis så du har för ett par fredagsmystillfällen framöver.", false, 99.00, "https://candypeople.se/wp-content/uploads/2015/04/jordgubbs_rolls-300x225.jpg", 25, "Jordgubb", 2.2));
                Products.Add(new Models.BulkCandy(16, "Frukttoppar", "Ihoprullade godisremsor med mumsig jordgubbssmak att köpa hem lagom till storkalaset eller om du vill bunkra upp med massa godis så du har för ett par fredagsmystillfällen framöver.", false, 99.00, "https://candypeople.se/wp-content/uploads/2015/04/frukt_toppar1-300x225.jpg", 25, "Fruktsmak", 2.0));
            }
            return Products;


        }
        /// <summary>
        /// Method for searching the productlist for users specific searchterm.
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public static List<Models.Product> Search(string searchTerm)
        {
            List<Models.Product> AllProducts = GetAllProducts();

            if (string.IsNullOrEmpty(searchTerm))
            {
                return AllProducts;
            }
            return AllProducts.Where(product => product.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        public static void AddProduct(Models.Product productToAdd)
        {
            Products.Add(productToAdd);
        }
        public static List<Models.Product> StockChanges(int id)
        {
            Product = Products.Where(product => product.Id == id).FirstOrDefault();
            Product.StockQuantity = Product.StockQuantity - 1;

            return Products;
        }

        public static List<Models.Product> DeleteProduct(int id)
        {
            Models.Product productToDelete = null;

            productToDelete = Products.Where(product => product.Id == id).FirstOrDefault();
            Products.Remove(productToDelete);

            return Products;
        }
        public static List<Models.Product> UpdateProduct(int id, string changes)
        {
            Product = Products.Where(product => product.Id == id).FirstOrDefault();
            Product.Name = changes;

            return Products;
        }

    }
}





