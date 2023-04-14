using System;


namespace Interface_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Idemo e = new Circle();
            
            e.Dimension = 10;
            
            Console.WriteLine("primeter:"+e.perimeter());
            Console.WriteLine("Area:"+e.Area());

        }
    }
    interface Idemo
    {
        int Dimension { get; set; }
        double Area();
        double perimeter();
    }
    public class Circle : Idemo
    {
        private int _Radius;
            
        public int Dimension
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = value;
            }
        }
        public  double Area()
        {
            return Math.PI* _Radius * _Radius;
        }
        public double perimeter()
        {
            return 2*3.14*_Radius;
        }
    }
}
