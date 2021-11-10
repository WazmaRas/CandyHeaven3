using CandyHeaven.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeaven.Data
{
    public class ProductManager
    {

        public static List<Models.Product> GetAllProducts()
        {
            List<Models.Product> products = new List<Models.Product>();

            products.Add(new Models.Bar("Barmony Salted Caramel", 17, "https://candypeople.se/wp-content/uploads/2020/06/barmony-caramel-300x232.jpg", 1, false, 100, "En balanserad snackbar av nötter med inslag av salted caramel", "salted caramel"));
            products.Add(new Models.Bar("Barmony Pecan/Sea Salt", 17, "https://candypeople.se/wp-content/uploads/2019/05/barmony_pecan-300x232.jpg", 2, false, 100, "En balanserad snackbar av nötter", "pecan/seasalt"));
            products.Add(new Models.Bar("Barmony Salty Chocolate", 17, "https://candypeople.se/wp-content/uploads/2019/05/barmony_saly_chocolate-300x232.jpg", 3, false, 100, "En balanserad snackbar av nötter med chokladdragerad undersida", "saltchoklad"));
            products.Add(new Models.Bar("Flapjack Berrylicious", 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50387_Flapjack_berry-300x232.jpg", 4, false, 100, "En bakad bar gjord av främst havre och sirap med inslag av torkade bär", "bärsmak"));
            products.Add(new Models.Bar("Flapjack Pistachio", 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50385_flapjack_pistachio-300x232.jpg", 5, true, 100, "En bakad bar gjord av främst havre och sirap med inslag av pistachnöt", "pistage"));
            products.Add(new Models.Bar("Barmony Salty Chocolate", 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50385_flpajack_darkchocolate-300x232.jpg", 6, true, 100, "En balanserad snackbar av nötter med chokladdragerad undersida", "salty chocolate"));
            products.Add(new Models.CandyBag("Frukttoppar", 15.90, "https://candypeople.se/wp-content/uploads/2017/10/113300_Frukttoppar_140g_utan_logga-300x232.jpg", 7, false, 25, "Dragerat skumgodis med smak av jordgubbe, päron och persika/aprikos", 120));
            products.Add(new Models.CandyBag("Jordnötsringar", 29.90, "https://candypeople.se/wp-content/uploads/2020/11/50420_Chokladdoppade_Jordn%C3%B6tsringar-300x232.jpg", 8, true, 25, "Krispiga jordnötsringar doppade i mjölkchoklad", 120));
            products.Add(new Models.CandyBag("S-märken Supersurt", 9.90, "https://candypeople.se/wp-content/uploads/2015/09/supersurt-300x225.jpg", 9, false, 25, "S-märken är ett gelegodis med supersurt sockeröverdrag.", 120));
            products.Add(new Models.CandyBag("S-märken Supersalt", 9.90, "https://candypeople.se/wp-content/uploads/2015/09/supersalt-300x225.jpg", 10, false, 25, "S-märke Supersalt är en lakritsgelegodis med supersalt överdrag.", 120));
            products.Add(new Models.CandyBag("Sura Colanappar", 9.90, "https://candypeople.se/wp-content/uploads/2017/10/50135_Originals_SuraColanappar_80g-300x232.jpg", 11, false, 25, "Sura vingumminappar med en riklig smak utav cola tillsammans med syrligt sockeröverdrag. Produkten är vegansk.", 120));
            products.Add(new Models.BulkCandy("Smultronmatta", 99.00, "https://candypeople.se/wp-content/uploads/2015/04/smultron_matta-300x225.jpg", 12, false, 0, "", "smultron"));
            products.Add(new Models.BulkCandy("Söt lakritsmatta", 159.00, "https://candypeople.se/wp-content/uploads/2015/04/lakrits_matta-300x225.jpg", 13, false, 25, "", "lakrits"));
            products.Add(new Models.BulkCandy("Lakritsbitar", 199.00, "https://candypeople.se/wp-content/uploads/2015/04/lakrits_bitar-300x225.jpg", 14, false, 15, "Ibland är allt som krävs för en lyckad kväll 2.2 kg lakrits i storpack! Säkra din låda redan idag så du inte sitter lakritslös på lördag!", "lakrits"));
            products.Add(new Models.BulkCandy("Jordgubbsrolls", 99.00, "https://candypeople.se/wp-content/uploads/2015/04/jordgubbs_rolls-300x225.jpg", 15, false, 15, "Ihoprullade godisremsor med mumsig jordgubbssmak att köpa hem lagom till storkalaset eller om du vill bunkra upp med massa godis så du har för ett par fredagsmystillfällen framöver.", "jordgubb"));
            products.Add(new Models.BulkCandy("Frukttoppar", 99.00, "https://candypeople.se/wp-content/uploads/2015/04/frukt_toppar1-300x225.jpg", 16, false, 15, "", "fruktsmak"));

            return products;
        }

        public static List<Models.Product> Search(string searchTerm)
        {
          List<Models.Product> AllProducts = GetAllProducts();

            if (string.IsNullOrEmpty(searchTerm))
            {
                return AllProducts;
            }
            return AllProducts.Where(product => product.Name.ToLower().Contains(searchTerm)).ToList();

        }


    }
}
