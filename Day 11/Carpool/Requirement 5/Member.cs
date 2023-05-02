using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
{
    public class Member
    {
        string firstname;
        string lastname;
        string emailid;
        int contactnum;
        int license;

        public Member()
        {

        }
        public Member(string firstname, string lastname, string emailid, int contactnum, int license)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailid = emailid;
            this.contactnum = contactnum;
            this.license = license;

        }
        public override string ToString()
        {
            return string.Format($"Member:{firstname},{lastname},{emailid},{contactnum},{license}");
        }

        public void checking(string email)
        {
            if (email.Contains("@") && ((email.EndsWith(".com")) || (email.EndsWith(".org"))))

            {
                Console.WriteLine("valid mail");
            }
            else
            {
                throw new InvalidEmailException(email);
            }
        }
    }
}
