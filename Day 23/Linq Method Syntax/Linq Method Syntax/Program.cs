using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Method_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int>list= new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);


            var que=list.Where (s=>s>5).ToList<int>();
            foreach (var s in que)
            {
                Console.WriteLine(s);
            }
        }
    }
}
