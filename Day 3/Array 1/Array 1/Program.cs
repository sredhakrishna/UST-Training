using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your code at here");
            int[] array = new int[5];
            int a;
            Console.WriteLine("enter 5 elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i]);

            }
        }
    }
}
