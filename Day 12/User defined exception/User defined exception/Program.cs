using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name,accnum , and amount to be debited");
            string name=Console.ReadLine();
            long acc=int.Parse(Console.ReadLine());
            decimal amt=decimal.Parse(Console.ReadLine());

            Customer customer = new Customer(name,acc,2000);
            try
            {
                customer.withDraw(amt);
            }
            catch(BankException e)
            {
                Console.WriteLine(e.Message);
                e.inform();
            }
        }
    }
}
