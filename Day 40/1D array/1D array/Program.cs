using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter leap");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("enter elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
        public static bool fun(int[] arr, int n, int l)
        {
            for (int i = 0;i < n; i++)
            {
                if(i+1!=0&& arr[i] == 0)
                {
                    i = i + 1;
                }
                if (i - 1 != 0 && arr[i] == 0)
                {
                    i = i - 1;
                }
                if (i + l != 0 && arr[i] == 0)
                {
                    i = i + l;
                }
                if (i == n - 1 ||i+l>=n)
                {
                   return true;
                }
                return false;
            }
        }
    } 
}
