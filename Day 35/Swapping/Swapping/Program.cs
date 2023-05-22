using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Sredha";
            char[]b=a.ToCharArray();
            char temp ;
            int i = 0;
           while(i<b.Length )
            {
                temp = b[i];
                b[i] = a[i+1];
                b[i+1] = temp;
                i = i + 2;

            }

            string str = "";
            for(int k=0; k<b.Length; k++)
            {
                str=str + b[k];
            }
            Console.WriteLine(str);
        }
    }
}
