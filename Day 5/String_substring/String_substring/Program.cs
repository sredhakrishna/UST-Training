using System;
using System.Runtime.Remoting.Services;
// Write a program in C# Sharp to search the position of a substring within a string

namespace String_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, sub;
            Console.WriteLine("enter string and substring");
            str = Console.ReadLine();
            sub=Console.ReadLine();
            int a=str.IndexOf(sub);
            if (a > 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}
