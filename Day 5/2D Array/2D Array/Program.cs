using System;
//Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix
namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[3, 3];
            Console.WriteLine(  "ener 3 nums ");
            for(int i = 0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    array2d[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\nThe matrix is : \n");
            for (int i = 0;i < 3; i++)
            {
                Console.Write("\n");
                for ( int j=0;j < 3; j++)
                {
                    Console.WriteLine("\t"+array2d[i,j]);
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
