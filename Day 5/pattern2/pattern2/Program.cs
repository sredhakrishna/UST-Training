﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine(  "enter size");
            n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
