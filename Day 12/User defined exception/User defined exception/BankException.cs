using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exception
{
      public class BankException:Exception
    {
        long accnum;
        decimal balance;
        decimal amt;
        public BankException(long accnum,decimal balance,decimal amt) 
        {
            accnum = accnum;
            this.balance = balance;
            this.amt = amt;
        }
        public void inform()
        {
            Console.WriteLine("insufficient fund for"+accnum+"Blance amount is"+(balance-amt));
        }
    }
}
