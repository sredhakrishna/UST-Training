using System;

namespace oops2
{
    public class Account
    {

        int Id;
        string Name;
        decimal Balance;

        public void create(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
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
            Balance = amount + Balance;
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
                Balance=Balance-amount1;
                Console.WriteLine(  "balance is"+Balance);
            }
        }
    }
}