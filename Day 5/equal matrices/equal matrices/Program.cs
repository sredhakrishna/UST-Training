using System;
//matrix comparison

namespace equal_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2,2];
            Console.WriteLine(  "enter matrix values");
            for(int i=0;i<2;i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] b = new int[2, 2];
            Console.WriteLine("enter matrix values");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0;i<2;i++)
            {
                for(int j = 0; j<2; j++)
                {
                    if (a[i,j] == b[i, j])
                    {
                        Console.WriteLine("equal");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(  "not equal");
                        break;
                    }
                    
                } 
            }
        }
    }
}
