﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");

            Console.WriteLine("FullName: {0}", dir.FullName);

            Console.WriteLine("Name: {0}", dir.Name);

            Console.WriteLine("Parent: {0}", dir.Parent);

            Console.WriteLine("Creation: {0}", dir.CreationTime);

            Console.WriteLine("Attributes: {0}", dir.Attributes);

            Console.WriteLine("Root: {0}", dir.Root);
        }
    }
}
