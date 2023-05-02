using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamwriter_and_reader
{
    
    internal class Program
    {
        static string file = @"D:\Ust Training\Day 12\Streamwriter and reader\poem.txt";
        static void Main(string[] args)
        {
            Write();
           // Read();
        }
        static void Write()
        {
            StreamWriter filestream= new StreamWriter(file);
            filestream.WriteLine("sraaaaaaaaa");
            filestream.WriteLine("u againnnnnnnnn");
            filestream.Close();
        }
    }
}
