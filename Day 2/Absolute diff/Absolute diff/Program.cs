using System;
//Write a code block to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference. 


namespace Absolute_diff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.WriteLine("enter a num");
            n= double.Parse(Console.ReadLine());
            double diff = Absdiff(n);
            Console.WriteLine("Absolute difference is"+diff);

        }
        static double Absdiff(double r) 
        {
            if (r > 51)
            { 
                r=Math.Abs(r-51);
                return r * 3;

               
            }
            else 
            { return  Math.Abs(r - 51); }
        }
    }
}
