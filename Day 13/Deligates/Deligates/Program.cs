using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    internal class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("sum is :"+(a+b));

        }
        static void Sub(int a, int b)
        {
            Console.WriteLine("sub is:"+(a - b));

        }
        public delegate void refmethod(int a, int b);
        
        static void Main(string[] args)
        {/*single Delegation
            Add(10, 5);
            refmethod r1 = Add;
            r1.Invoke(10,5);

            Sub(10, 5);
            refmethod r2 = Sub;
            r2.Invoke(10, 5);*/

            //multiple delegation
            refmethod multicast = Add;
            multicast += Sub;
            //multicast += Multiply;
            multicast(10, 5);
            Console.WriteLine("after removal");

        }
    }
}
