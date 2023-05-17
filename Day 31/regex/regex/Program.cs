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
            string s = "sredha krishna";

            string p = "@^[aeiouAEIOU]+$";
            if (Regex.IsMatch(s, p) == true)
            {
                Regex.Replace(s, p, "3");
            }
            Console.WriteLine(s);
        }
    }
}
