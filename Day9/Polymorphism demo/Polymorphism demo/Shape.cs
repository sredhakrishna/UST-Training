using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_demo
{
    public class Shape
    {
        public virtual void Drawshape()// on the  time of polymorphysm baseclass should be mentioned as virtual
        {
            Console.WriteLine(  "drawing:shape");
        }
    }
}
