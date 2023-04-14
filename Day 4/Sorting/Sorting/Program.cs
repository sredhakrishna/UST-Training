using System;


namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter num of elements");
            int a=int.Parse( Console.ReadLine() );
            int[] arr = new int[a];
            Console.WriteLine(  "enter array elements");
            for(int i=0; i < a; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
             Sort(arr);
            printArray(arr);
        }
        static void Sort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }


    }
}
