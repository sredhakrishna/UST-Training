using EntityFrameworkCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
                var b = new Grade() { GradeId = 1, GradeName = "fifth" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                ctx.Grades.Add(b);
                ctx.SaveChanges();
            }
        }
    }
}
