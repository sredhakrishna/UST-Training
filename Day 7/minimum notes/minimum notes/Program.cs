using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter a digit: ");
            int amt = int.Parse(Console.ReadLine());
            int[] arr = { 2000, 500, 100, 50, 20, 10, 5,2, 1 };
            
            for (int i = 0; i < 9; i++)
            {
                int a = amt / arr[i];
                amt = amt %= arr[i];

                Console.WriteLine(a);
            }
            {

            }
        }
    }
}
