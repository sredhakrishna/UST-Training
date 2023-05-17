using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice
{
    public class Teacher:Person
    {
        private string _subject;
        public string Subject { 
            get { return _subject; }
            set { _subject = value;}
        }
        public Teacher()
        {

        }
        public Teacher(string subject)
        {
            Subject = subject;  
        }
        public void Explian()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
