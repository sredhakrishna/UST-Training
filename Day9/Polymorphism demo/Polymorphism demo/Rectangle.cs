using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_demo
{
    internal class Rectangle:Shape
    {
        public override void Drawshape()//the most imp onr should be marked as overriding
        {
            Console.WriteLine("drawing:Rectangle");
        }
    }
}
