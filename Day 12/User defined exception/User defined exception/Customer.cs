using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exception
{
    public  class Customer
    {
        private string _name;
        private long _accountNum;
        private decimal _balance;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long AccountNum
        {
            get { return _accountNum; }
            set { _accountNum = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public Customer()
        {

        }
        public Customer( string name, long accountNum, decimal balance)
        {
            Name = name;
            AccountNum = accountNum;
            Balance = balance;
            
        }

        public decimal withDraw(decimal amt)
        {
            if (Balance - amt <= 0)
            {
                throw new BankException(AccountNum, Balance,amt);
                return amt;
            }
            else
            {
                return Balance= Balance - amt;
            }
           
        }
        public decimal display(decimal Balance)
        {
            return Balance;
        }
    }
}
