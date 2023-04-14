using System;

// Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
namespace voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("enter your age");
            a = int.Parse(Console.ReadLine());
            string b;
            b = Checking(a);
            Console.WriteLine(b);
        }
        static string Checking(int a) 
        {
            string c;
            if (a >= 18)
            {
                //c = true;
                c = "eligible";
            }      
            else
            { 
                c = "not";
            }
            return c;
        }
        }
       
    }

