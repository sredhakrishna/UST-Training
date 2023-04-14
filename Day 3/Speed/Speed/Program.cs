using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 0.0,time=0;
            Console.WriteLine( "enter distance");
            distance=double.Parse( Console.ReadLine() );
            Console.WriteLine("enter time");
            time = double.Parse( Console.ReadLine() );
            double speed11 = speed1(distance, time);
            double speed22=speed2(distance,time);
            Console.WriteLine($"in km/hr:{speed11}");
            Console.WriteLine($"in mile/hr:{speed22}");


        }
        static double speed1(double distance, double time)
        {
            return distance * time;
        }
        static double speed2(double distance, double time)
        {
            return (distance * time)/1.6;
        }
    }
}
