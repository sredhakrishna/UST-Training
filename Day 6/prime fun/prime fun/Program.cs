using System;
//prime
namespace prime_fun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the num");
            n=int.Parse(Console.ReadLine());
            IsPrime(n);

        }
        static void IsPrime(int n)
        {
            for(int i = 2; i < n/2; i++) 
            {
                if (n % i == 0)
                {
                    Console.WriteLine("not a prime");
                    break;

                }
                else
                {
                    Console.WriteLine("prime");
                }
            }
        }
    }
}
