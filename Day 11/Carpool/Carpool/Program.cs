using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> List1 = new List<Member>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter the details");
                long id = int.Parse(Console.ReadLine());
                string firstname = Console.ReadLine();
                string lastname = Console.ReadLine();
                string email = Console.ReadLine();
                string contactnumber = Console.ReadLine();
                string licensenumber = Console.ReadLine();
                DateTime startDate = DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy",null);
                DateTime expiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null); 
                Member member = new Member(id,firstname,lastname,email,contactnumber, licensenumber,startDate,expiryDate );
                List1.Add(member);
               
            }
            foreach (Member m in List1)
            {
                Console.WriteLine(m.ToString());
            }
            if (List1[0].Equals(List1[1]))
            {
                Console.WriteLine("Member1 is same as member2");
            }
            else
            {
                Console.WriteLine("member1 and 2 are different");
            }
        }
    }
}
