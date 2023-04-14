using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int i=0;
            int[ ] arr = new int[10];
            while(n>0) 
            {
                arr[i]= n % 2;
                n= n / 2;
               i++;
            }
            for( int j=i-1; j>=0; j--)
            {
                Console.Write(arr[j]);

            }
            
        }
    }
}
