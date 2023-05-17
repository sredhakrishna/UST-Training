using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_qn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 2, 7, 11, 15 };
            int target = 9;
            
            Console.WriteLine(b);
            int[] c = TwoSum(b, target);
            foreach(int x in c) Console.Write(x);
        }
       
        
            public  static int[] TwoSum(int[] nums, int target)
            {
                int[] a=new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] + nums[i] == target)
                        {
                        a[0] = nums[i];
                        a[1] = nums[j];
                        break;
                        }
                    }


                }
                return a;
            }
        }
    }

