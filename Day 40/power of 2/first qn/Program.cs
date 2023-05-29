using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_qn
{

    class Program

    {

        static void Main(string[] args)

        {
            Console.WriteLine("enter n");
            int n=int.Parse(Console.ReadLine());
            solution.inner s1= new solution.inner();
            
            bool check = s1.isPowerOfTwo(n);

            
            if(check)
            {
                Console.WriteLine(n+" is a power of 2");
            }
            else { Console.WriteLine(n + " is not a power of 2"); }

            Console.ReadKey();

        }

      /*  public static bool isPowerOfTwo(int x)

        {

            while (((x % 2) == 0) && x > 1)

            {

                x /= 2;

            }

            return (x == 1);

        }*/
    }
}

