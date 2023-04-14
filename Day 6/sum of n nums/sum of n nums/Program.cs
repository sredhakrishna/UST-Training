using System;


namespace sum_of_n_nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine(  "enter n");
            int n=int.Parse( Console.ReadLine() );
            for(int i=0; i < n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
