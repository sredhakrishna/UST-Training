//Write a program in C# Sharp to find the length of a string without using library function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter a string");
            string str= Console.ReadLine();
            char [] chararray= str.ToCharArray();
            int a = 0;
            for(int i = 0; i < chararray.Length; i++)
            {
                a = a + 1;
            }
            Console.Write("size is:"+a);
        }
    }
}
