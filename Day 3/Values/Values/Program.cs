using System;
//Write a Code Block to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.


namespace Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0; int b=0;
            Console.WriteLine("enter a num");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the scnd num");
            b=int.Parse(Console.ReadLine());
            int c = sum(a,b);
            Console.WriteLine(c);
        }
        static int sum(int a, int b)
        {
            if (a == b)
            {
                return 3*(a + b);
            }
            else
            {
                return a + b;
            }
        }
    }
}
