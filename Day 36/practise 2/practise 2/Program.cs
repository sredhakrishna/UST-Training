using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "malayalam";
            int b = checking(s);
            if (b == 1)
            {
                Console.WriteLine("valid");

            }
            else { Console.WriteLine("not valid"); }
        }
        public static int checking(string s)
        {
            if (s[0] == s[s.Length - 1])
            {
                return 1;
            }
            return 0;
        }
    }
}
