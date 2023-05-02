using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Anonymous_method_2
{
    internal class Program
    {
        public delegate int Sum(int x, int y);
        static void Main(string[] args)
        {
            int result;
            Sum s = delegate (int m, int n)
            {
                return m + n;
            };
            result = s(10, 20);
            Console.WriteLine(result);
        }
        
    }
}
