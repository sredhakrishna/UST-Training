
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList();
            arlist.Add(3);
            arlist.Add("SREDHA");
            arlist.Add('R');
            arlist.Add(true);
            arlist.Add(2);
            foreach (var elements in arlist)
            {
                Console.WriteLine(elements);
            }

            Console.WriteLine("**********************************");
            arlist.Remove(3);
            arlist.RemoveAt(2);
            arlist.Insert(3, "ok da");
            Console.WriteLine(arlist.IndexOf("ok da"));
            Console.WriteLine("**********************************");

            foreach (var elements in arlist)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
