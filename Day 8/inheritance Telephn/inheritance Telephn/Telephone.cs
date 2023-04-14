using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Telephn
{
    internal class Telephone
    {
        protected string phonetype;
        public Telephone()
        { 
        }
        public Telephone(string phonetype)
        {
            this.phonetype = phonetype;
        }
        public void Ring()
        {
            Console.WriteLine("Ringing the"+phonetype);
        }

    }
}
