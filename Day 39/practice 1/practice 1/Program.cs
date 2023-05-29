using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter student type");
            string str=Console.ReadLine();
            if (str == "MSH")
            {
                Console.WriteLine("Enter tuition fee");
                float tf=float.Parse(Console.ReadLine());
                Console.WriteLine("enter bus fee");
                float bf=float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee");
                float hf = float.Parse(Console.ReadLine());
                float total = tf + hf;
                Console.WriteLine("The fees to be paid by the student is Rs:" + $"{total:0.00}");
                //or Console.WriteLine("The fees to be psid is:"+total.Tostring("0.00"));
                
            }
            if (str == "MSDS")
            {
                Console.WriteLine("Enter tuition fee");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee");
                float bf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee");
                float hf = float.Parse(Console.ReadLine());
                float total = tf + bf;
                Console.WriteLine("The fees to be paid by the student is Rs:" +$"{ total:0.00}");
            }
            if (str == "MGSDS")
            {
                Console.WriteLine("Enter tuition fee");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter bus fee");
                float bf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee");
                float hf=float.Parse(Console.ReadLine());
                float total = ((150*tf)/100) + bf;
                Console.WriteLine("The fees to be paid by the student is Rs{0:0.00}" + $"{total:0.00}");
            }
            if (str == "MGSH")
            {
                Console.WriteLine("Enter tuition fee");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter bus fee");
                float bf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee");
                float hf = float.Parse(Console.ReadLine());
                float total = ((150 * tf) / 100) + hf;
                Console.WriteLine("The fees to be paid by the student is Rs{0:0.00}" + $"{total:0.00}");
            }
        }
    }
}
