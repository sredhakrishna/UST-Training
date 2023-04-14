using System;
//Write a program in C# Sharp to separate odd and even integers in separate arrays

namespace arrayodd_and_even_seperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter arry size");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter elements");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] array2 = new int[n];
            int[] array3 = new int[n];
            int j = 0, k = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array2[j] = array[i];

                    j++;
                }
                else
                {

                    array3[k] = array[i];
                    k++;



                }
            }
            Console.WriteLine("Array of even element is");
            for (int i = 0; i < j; i++)
            {
                Console.Write(array2[i]+"\n");
            }
            Console.WriteLine(  "Array of odd elements is");
            for (int i = 0; i < k; i++)
            {
                Console.Write(array3[i]+"\t");
            }
        }
    }
}