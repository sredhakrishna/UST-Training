
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int n1 = 0;
            int n2 = 1; 
            int n3 = 0;
            Console.WriteLine("enter the limit");
            n=int.Parse(Console.ReadLine());
            Console.Write("01");
            for(int i = 3; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3);
             
                n1 = n2;
                n2 = n3;

            }
            
           ;
        }
    }
}
