using System;
using System.Linq;
//Write a program in C# Sharp to count the frequency of each element of an array.

namespace array_frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] visited = new bool[1000];
            int count =0;
            int[] array = { 1, 6, 3, 1, 4, 3, 4, 6, 22, 2 };
            array.Append(55);
            for (int k = 0; k < array.Length; k++)
            {
                //array[k] = 55;
                Console.WriteLine(array[k]);
            }
            for (int i=0; i<array.Length; i++)
            { count = 0;
                if (visited[i]==true)
                    continue;
                for(int j=0; j<array.Length; j++)
                {
                    
                        if (array[i] == array[j])
                        {
                            visited[j] = true;
                            count++;
                        
                        }
                   
                }
                if (count != 0)
                {
                    Console.WriteLine("frequency of " + "   "+array[i] +"   "+"is"+"   "+(count));   
                }
            }
        }
    }
}
