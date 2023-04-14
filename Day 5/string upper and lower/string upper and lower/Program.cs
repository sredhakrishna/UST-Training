
using System;


namespace string_upper_and_lower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter a string");
            string str=Console.ReadLine();
            char[] chars = str.ToCharArray();
            for(int i=0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                    Console.WriteLine(chars[i]);
                }
                else
                {
                    Console.WriteLine(char.ToLower(chars[i]));    
                }
            }
        }
    }
}
