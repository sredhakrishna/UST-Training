using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* using (var context = new EFDBEntities())
             {
                 var std = new Dept()
                 {
                     DeptId = 8,

                 };
                 context.Depts.Add(std);

                 context.SaveChanges();
             }
             EFDBEntities e= new EFDBEntities();
             foreach(var i in e.Depts)
             {
                 Console.WriteLine(i.DeptId);
             }*/
            /*using (var context = new EFDBEntities())
            {
                var std = context.Depts.First<Dept>();
                std.DeptName = "Steve";
                context.SaveChanges();
            }*/

            using (var a = new EFDBEntities())
            {
                var s = a.Depts.Where(y => y.DeptId == 7).First<Dept>();
                s.DeptName = "ggg";
                a.SaveChanges();
            }
        }
        
    }
}
