using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "210";
            int result = check(str);
            Console.WriteLine(result);
        }

        private static int check(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='0' || str[i]=='1')
                {
                    count++;
                }
                if (count == str.Length)
                {
                    return 1;
                }

                
            }
            return 0;

        }
    }
}
