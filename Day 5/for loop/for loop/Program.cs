using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, d;
            Console.WriteLine(  "enter 2 nums");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            
            if (a < b)
            {
                c = a;
                d = b;
                
            }
            else
            {
                c = b;
                d = a;
                
            }
            for(int i=c; i<=d; i++)
            { 
                Console.WriteLine( i );
            }
        }
    }
}
