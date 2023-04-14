using System;
//finding unique element
namespace Array_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            int[] array = {  8, 4, 3, 8, 5, 4,99 };
            for(int i=0; i<array.Length; i++)
            {
                count = 0;
                for (int j=0; j<array.Length; j++)
                {
                    if (i != j)
                    {
                        if (array[i] == array[j])
                        {
                            count++;

                        }
                    }
                   
                }
                if (count == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            
        }
    }
}
