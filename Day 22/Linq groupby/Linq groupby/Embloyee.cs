using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_groupby
{
    public class Embloyee
    {
        private string city;
        private string name;

        public string City
        {
            get { return city; } set {  city = value; }
        }
        public string Name
        {
            get { return name; } set { name = value;}
        }
        public Embloyee()
        {

        }
        public Embloyee(string name, string city)
        {
            this.city = city;   
            this.name = name;
        }

    }
}
