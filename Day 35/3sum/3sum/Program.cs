using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
           List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < nums.Length; j++)
                {

                    for (int k = 0; k < nums.Length; k++)

                    {

                        if (nums[i] != nums[j] &&nums[ i] !=nums[ k] &&nums[ k] != nums[j])
                        {

                            if (nums[i] + nums[j] + nums[k] == 0)
                            {

                                list.Add(new int(nums[i], nums[j], nums[k]));
                               ;

                                

                            }

                        }

                    }

                }

            }
            foreach (int i in list)
            {
                Console.WriteLine(list);
            }

        }
    }
}
