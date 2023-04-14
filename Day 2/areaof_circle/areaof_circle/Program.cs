using System;
//Write a code block for Calculate Area of Circle. Get radius as an input and display calculated area on screen.
namespace MyNamespace
{
    class area
    { 
        static void Main(string[] args)
        {
            double r = 0.0, area;
            Console.WriteLine("enter radius");
            r=double.Parse(Console.ReadLine());
            // double ans = 3.14 * r * r;
            //Console.WriteLine(ans);
            area = CalcArea(r);
            Console.WriteLine("Area is::"+area);

        }
        static double CalcArea(double rr)
        {
            double area1 = rr * rr * 3.14;
            return area1;
        }
    }
}
