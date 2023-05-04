using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_groupby
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Embloyee> EmpList = new List<Embloyee>();
         {EmpList.Add(new Embloyee ("sredha","tvm"));
          EmpList.Add(new Embloyee ("manjima","tvm"));
          EmpList.Add(new Embloyee ("anusree","pkd"));
          EmpList.Add(new Embloyee ("anjana","mlp"));
          EmpList.Add(new Embloyee ("shyam","mlp"));
          EmpList.Add(new Embloyee("sree","kkd"));
         }

            var Equery = from Embloyee emp  in EmpList
                         orderby emp.City
                         group emp by emp.City;
            foreach (var e in Equery)
            {

                Console.WriteLine("Employee with " + e.Key + " City: ");

                foreach (var nm in e)

                {

                    Console.WriteLine(" " + nm.Name);

                }
            }
        }
    }
}
