using System;
//Write a program in C# Sharp to count a total number of duplicate elements in an array
namespace Array_duplicate_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                }


                Console.Write( "duplicate of"+arr[i]+"occurs" +count);

            }
            Console.WriteLine(  );
        }
    }
}
