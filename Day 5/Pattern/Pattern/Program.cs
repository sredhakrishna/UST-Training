using System;
//pattern printing........................

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
