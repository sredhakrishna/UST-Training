using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_arraay_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num of elements");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("enter elements");
            int[] ar=new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i]=int.Parse(Console.ReadLine());
            }
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
