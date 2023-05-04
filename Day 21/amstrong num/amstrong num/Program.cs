using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a 3 digit num");
            int a = int.Parse(Console.ReadLine());
            bool result = AmNum(a);
            Console.WriteLine(result);
        }
        static bool AmNum(int n)
        {
            int a = 0;
            int b = n;
            int temp = 0;
            while (n > 0)
            {
                a = n % 10;
                temp= temp+(a*a*a);
                n /= 10;
                
            }
            if(b==temp)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
