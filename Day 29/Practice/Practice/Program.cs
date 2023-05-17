using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name");

            Console.WriteLine("Enter the product id");
            Console.WriteLine("Enter the supplier name");


            
            Product p = new Product();
            p._productName=Console.ReadLine();
            p._id = Convert.ToInt64(Console.ReadLine());
            p._supplierName = Console.ReadLine();
            Console.WriteLine("Supplier Name is " + p._supplierName);
            Console.WriteLine("Product Name is " + p._productName);
            Console.WriteLine("Product Id is "+p._id);
        }
    }
}
