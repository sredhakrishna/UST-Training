using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hey, im here";

            string s2 = Regex.Replace(s, "[^A-Za-z\\s]", "");
            Console.WriteLine(s2);
            string[] s3 = s2.Split(' ');
            double l= s3.Length;
            Console.WriteLine(l);
            string s5 = Regex.Replace(s, "[^A-Za-z]", "");
            Console.WriteLine(s5);
            double l2 = s5.Length;
            Console.WriteLine(l2);
            double AVG = l2 / l;
            Console.WriteLine(AVG);
            
        }
    }
}
