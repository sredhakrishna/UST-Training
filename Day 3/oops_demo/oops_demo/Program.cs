using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(  "enter embloyee name id and salary");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            
            decimal salary = decimal.Parse(Console.ReadLine());
            Emp e2 = new Emp(name,id,salary);
            Console.WriteLine( "id ,name ,salary     "+e2.Id +e2.Name+e2.Salary);

        }
    }
}
