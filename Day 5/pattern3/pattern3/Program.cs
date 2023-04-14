using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine(  "enter the size ");
            n=int.Parse( Console.ReadLine() );
            for (int i=n; i>0; i--)
            {
                for(int j=0; j<i; i++)
                {
                    Console.Write(" ");
                } 
                for(int  k=i; k>0; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
