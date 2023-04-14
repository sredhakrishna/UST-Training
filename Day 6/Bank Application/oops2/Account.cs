using System;

namespace oops2
{
    public class Account
    {

        int Id;
        private string _name;
        public string Name
        {
            get { return _name; }
            set { 
            
                 
                if (value.Length > 15)
                {
                    
                    _name= value;
                }
                else
                {
                    throw new ApplicationException("errorrrrrrr");
                }
            }
        }
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
        }

        public void create(int id, string name, decimal balance)
        {
            Id = id;
            _name = name;
            _balance = balance;
            Console.WriteLine(  "acc created successfully");
        }

        public void display()
        {
            Console.WriteLine(  "id is "+Id);
            Console.WriteLine("name is " + Name);
            Console.WriteLine("salary is " + Balance    );
        }

        public void deposite(decimal amount)
        {
            _balance = amount + Balance;
            Console.WriteLine(Balance);
        }

        public void withdraw(decimal amount1)
        {
            if (Balance - amount1 < 500) 
            {
                Console.WriteLine(  "insufficient balance");
            }
            else
            {
                _balance =Balance-amount1;
                Console.WriteLine(  "balance is"+Balance);
            }
        }
    }
}