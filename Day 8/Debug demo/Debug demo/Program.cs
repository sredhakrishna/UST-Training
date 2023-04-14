using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter a num");
            int i=int.Parse( Console.ReadLine() );
            Console.WriteLine("enter scnd num");
            int j=int.Parse( Console.ReadLine() ) ;
            Fun(i,j);
        }
        public static void Fun(int x,int y)
        {
            int t = 100;
            for(int i=x;i<=y;i++)
            {
                Console.WriteLine("sredha");
                t = t + 34;
            }
        }
    }
}
