using System.Threading.Tasks;
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Method0();
        Method1();
        Method2();
        Console.ReadKey();
    }
    public static async Task Method0()
    {
        await Task.Delay(10000);
        for(int i = 0; i < 101; i++) 
        {
            Console.WriteLine(i);
        }
    }
    public static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Method 1");
                // Do something
                Task.Delay(100).Wait();
            }
        });
    }


    public static void Method2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(" Method 2");
            // Do something
            Task.Delay(100).Wait();
        }
    }
     
}