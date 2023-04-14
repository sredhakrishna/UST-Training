using System;
namespace matrix_addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2 }, { 4, 5 } };
            int[,] arr2 = { { 2, 7 }, { 4,9 } };
            int[,] arr3 = new int[2, 2];
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    arr3[i,j] = arr1[i, j] + arr2[i,j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                //Console.Write("\n");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("\t"+arr3[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
