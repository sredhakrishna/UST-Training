using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice_2
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Table[] array = new Table[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=new Table(rnd.Next(50,200),rnd.Next(50,200));
                array[i].Show();
            }
        }
    }
}
