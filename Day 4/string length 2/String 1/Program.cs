//Write a program in C# Sharp to find the length of a string without using library function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a strin");
            string str;
            str= Console.ReadLine();
            int a = total(str);
            Console.WriteLine(a);
        }
        static int total(string str)
        {
            int b = 0;
            foreach(char i in str)
            {
                b = b + 1;
            }
            return b;   
        }
    }
}
