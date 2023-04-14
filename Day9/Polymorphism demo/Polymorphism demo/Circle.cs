using System;

namespace Polymorphism_demo
{
    internal class Circle:Shape
    {
        public override void Drawshape()//the most imp onr should be marked as overriding
        {
            Console.WriteLine(  "drawing:Circle");
        }
    }
}
