using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure f = new square();
            Console.WriteLine(f.Area());
            Console.WriteLine(f.Perimeter());
        }
    }

   abstract class Figure
    {
        public int Dimension = 10;
        public abstract double Area();
        public abstract double Perimeter();

    }
      class square : Figure
    {
        public override double Area()
        {
            return Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return Math.PI *Dimension * Dimension;
        }
    }
}
