using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            long a=long.Parse(Console.ReadLine());
            chrcking(a);
        }
        public static void chrcking(long a) {
            string s = a.ToString();
            long sum = 0;
            for(int i = 0; i < s.Length; i++) {
                if (s[i] %2!= 0) {
                    sum = sum + s[i];
                }
            }
            if(sum%2!= 0)
            {
                Console.WriteLine("sum is odd");
            }
            else { Console.WriteLine("sum is even"); }
        }
    }
}
