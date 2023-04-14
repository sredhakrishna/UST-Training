using System;


namespace Bubble_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 3, 6, 8, 1, 33, 11 };
            sort(arr);
            print(arr);

        }
        static void sort(int[] arr)
        {
            int temp, min;
            for (int i = 0; i < arr.Length - 1; i++)
              
                for(int j=0; j<arr.Length; j++)
                
                    if (arr[i] > arr[j])
                    {
                    
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[j] = temp;  
                    }
                
            
        }
        static void print(int[] arr)
        {
            for(int i=0; i<arr.Length ; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(  );
            }
        }
    }
}
