using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_pallindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 111, 224, 333 };
            int result = check(a);
            Console.WriteLine(result);
        }
        static int check(int[] a)
        {
            int result = 0;
            int count = 0;
            int[] b = new int[a.Length];
            
            for(int i=0; i<a.Length; i++)
            {
                int c= a[i];
                
                int a1 = 0;
                while (a[i] > 0)
                {
                    a1 = a1 * 10 + a[i] % 10;

                    a[i] = a[i] / 10;
                }
                    if (c == a1)
                    {
                    count++;
                    }
                } 
            
            if (count==a.Length)
            {
                result=1;
            }
            return result;
        }
    }
}
