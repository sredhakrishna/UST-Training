using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_to_arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "amma", "acha" };
            ArrayList arlist = new ArrayList();
            arlist.AddRange(array);
            foreach (var elements in arlist) 
            {
                Console.WriteLine(elements);
            }
            for(int i=0;i<arlist.Count; i++)
            {
                Console.WriteLine(arlist[i]);
            }

        }
    }
}
