using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s=new SortedList();
            s.Add("sredha", "2000");
            s.Add("manjima", "3000");
            s.Add("anusree", "4000");
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
