using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_method_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> stlist = Student.GetStudents();
            var qe=stlist.Where(s=>s.Age>20&&s.Age<30).ToList();
            foreach( var s in qe)
            {
                Console.WriteLine(s.Name);
            }
        }
        
    }
}
