using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice_2
{
    public class Table
    {
        private int _height;
        private int _width;
        public int Height
        {

            get { return _height; }
            set { _height = value; }
        }
        public int Width
        { get { return _width; } set {  _width = value; } }

        public Table()
        {

        }
        public Table(int height, int width)
        {
            Height = height;
            Width = width;
            
        }
        public void Show()
        {
            Console.WriteLine("heigth"+Height);
            Console.WriteLine("width"+Width);
        }
       
        
    }
}
