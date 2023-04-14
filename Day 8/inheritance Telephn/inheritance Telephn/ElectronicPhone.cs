using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Telephn
{
    internal class ElectronicPhone:Telephone
    {
        public ElectronicPhone() 
        {
        }
        public ElectronicPhone(string phonetype)
            :base(phonetype)
        {
        }
        public void Run ()
        {
            base.Ring();
        }
        
    }
}
