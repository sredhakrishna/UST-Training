using System;
using System.Globalization;
//Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string
namespace String_counting_alphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "My name is @!%200099 sredha";
       
            char[] chars = str.ToCharArray();
            int count = 0;
            int dig = 0;
            int chare = 0;
            for (int i=0; i<chars.Length; i++)   
            {
                
                 
                if (chars[i] >= 'A' || chars[i] >= 'a' && chars[i] <= 'Z' || chars[i] >= 'a')
                {
                    count++;
                }
                else if (chars[i] >= '0' && chars[i] <= '9')
                {
                    dig++;
                }
                else
                {
                    chare++;
                }
                
            }
            Console.WriteLine("num of alphabets:"+count);
            Console.WriteLine("num of digits:"+dig);
            Console.WriteLine("num of charactors:"+chare);
        }
    }
}
