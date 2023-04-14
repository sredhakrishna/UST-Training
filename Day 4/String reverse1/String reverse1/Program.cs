using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_reverse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine(  "enter a string");
            str= Console.ReadLine();
            for(int i=str.Length-1; i>=0; i--)
            {
                Console.Write(str[i] +"\t");
            }
        }
    }
}
