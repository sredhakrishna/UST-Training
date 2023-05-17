using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice
{
    public class Student:Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("im going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + age);
        }
        public Student()
        {

        }
       
        }
    }

