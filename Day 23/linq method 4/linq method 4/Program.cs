using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_method_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 11, 20, 10, 33, 3 };
            IEnumerable<int> query = num.Where(n => n % 2 == 0).OrderBy(n1 => n1);
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
