using System;


namespace Polymorphism_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Drawshape();
            Circle c = new Circle();
            c.Drawshape();
            Rectangle r = new Rectangle();
            r.Drawshape();

            //upcating
            Shape s2 = new Circle();
            s2.Drawshape();


            Shape s3 = new Rectangle();
            s3.Drawshape();

            
            //Array of references of base class refering derived class object(upcasting)
        }
    }
}
