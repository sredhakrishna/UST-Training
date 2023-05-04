using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "hibiscuklihgghs" };
            var Qflower=from flower in flowers
                        let len=flower.Length
                        where len > 0&&len<7
                        select flower;
            foreach (var flower in Qflower)
            {
                Console.WriteLine(flower);
            }
        }
    }
}
