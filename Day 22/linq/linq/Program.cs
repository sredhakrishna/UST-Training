using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine($"{product.ProductName} is sold out!");
            }

            var query =from prod in products
                       where prod.Cost>3
                       select prod;

            foreach(var i in query)
            {
                Console.WriteLine($"product having money morethan 3  " + i.ProductName);
            }
            var query1 = from pr in products
                         where pr.Cost > 3 && pr.UnitsInStock != 0
                         select pr;
                foreach(var i in query1)
            {
                Console.WriteLine($"{i.ProductName}is available and cost is more than 3");

            }
                


        }

       
    }
}
