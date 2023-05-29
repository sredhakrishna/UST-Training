using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_qn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 27,36,21
            };
            int result = sol(list);
            Console.WriteLine(result);
        }

        private static int sol(List<int> list)
        {
            int score = 0;
           
            for(int i=0; i<list.Count-1; i++)
            {
                if ((list[i]+list[i+1])%2==0) 
                {
                    score += 5;
                }
            }
            for (int i = 0; i < list.Count - 2; i++)
            {
                if ((list[i] + list[i + 1] + list[i+2]) % 2 != 0&& (list[i] * list[i + 1] * list[i + 2]) % 2==0)
                {
                    score += 10;
                }
            }
            return score;
        }
    }
}
